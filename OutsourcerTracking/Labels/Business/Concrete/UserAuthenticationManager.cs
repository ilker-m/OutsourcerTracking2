using Microsoft.AspNetCore.Identity;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models;
using OutsourcerTracking.Models.UserAuthenticationModels;
using System.Net;
using System.Security.Claims;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class UserAuthenticationManager : IUserAuthenticationService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IUserDal _userDal;

        public UserAuthenticationManager(SignInManager<User> signInManager, UserManager<User> userManager, RoleManager<Role> roleManager, IUserDal userDal)
        {
            _roleManager = roleManager;
            _signInManager = signInManager;
            _userManager = userManager;
            _userDal = userDal;
        }

        public void ChangePassword(string userName, string password)
        {
            var user = _userDal.Get(u => u.UserName == userName);
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, password);
            user.IsFirst = false;
            _userDal.Update(user);
        }

        public ResultViewModel<User> ChangePasswordWithKeyCode(string KeyCode, string password)
        {
            var user = _userDal.Get(u => u.KeyCode == KeyCode);
            if (user!=null)
            {
                PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
                user.PasswordHash = passwordHasher.HashPassword(user, password);
                user.IsFirst = false;
                _userDal.Update(user);
                return new ResultViewModel<User> { Success = true };
            }
            else
            {
                return new ResultViewModel<User> { Success = false,Message="Güvenlik Kodu Geçersiz" };
            }
        }

        public async Task<ResultViewModel<User>> CheckAPIUserAsync(string base64)
        {
            byte[] data = Convert.FromBase64String(base64.Replace("Basic ", ""));
            string decodedString = System.Text.Encoding.UTF8.GetString(data);
            string email = decodedString.Split(":")[0];
            string password = decodedString.Split(":")[1];
            var user = _userDal.Get(u => u.Email == email);
            if (user == null)
                return new ResultViewModel<User> { Success = false, Message = "Kullanıcı Bulunamadı" };
            if (_userManager.GetRolesAsync(user).Result[0] != "API User")
                return new ResultViewModel<User> { Success = false, Message = "API Kullanıcısı Değil" };
            if (!await _userManager.CheckPasswordAsync(user, password))
                return new ResultViewModel<User> { Success = false, Message = "Şifre Hatalı" };
            return new ResultViewModel<User> { Success = true, Message = "", Object = user };
        }

        public async Task<ResultViewModel<ForgetPasswordModel>> CheckEmail(string email)
        {
            var user = _userDal.Get(u => u.Email == email);
            return user == null ? new ResultViewModel<ForgetPasswordModel> { Success = false, Message = "Girilen e-posta kayıtlı değil." } : new ResultViewModel<ForgetPasswordModel> { Success = true, Message = "" };
        }

        public async Task<ResultViewModel<User>> LoginAsync(UserAuthenticationLoginViewModel loginVM)
        {
            var user = _userDal.Get(u => u.Email ==  loginVM.Email);
            if (user == null)
                return new ResultViewModel<User> { Success = false, Message = "Kullanıcı Bulunamadı" };
            if (!user.IsActive)
                return new ResultViewModel<User> { Success = false, Message = "Kullanıcının hesabı aktif değil." };
            if (_userManager.GetRolesAsync(user).Result[0] == "API User")
                return new ResultViewModel<User> { Success = false, Message = "API kullanıcısı ile giriş yapılamaz." };
            if (!await _userManager.CheckPasswordAsync(user, loginVM.Password))
                return new ResultViewModel<User> { Success = false, Message = "Şifre Hatalı" };
            user.SecurityStamp = Guid.NewGuid().ToString();
            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
            if (result.Succeeded)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.FirstName)
                };
                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                return new ResultViewModel<User> { Success = true, Message = "Giriş yapıldı", Object = user };
            }
            else if (result.IsLockedOut)
            {
                return new ResultViewModel<User> { Success = false, Message = "Kullanıcı hesabı askıya alındı." };
            }
            else
            {
                return new ResultViewModel<User> { Success = false, Message = "Giriş işlemi sırasında hata oluştu." };
            }
        }
        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public void RecordKeyCode(string email)
        {
            var user = _userDal.Get(u => u.Email == email);
            user.KeyCode = Guid.NewGuid().ToString().Substring(0,6);
            _userDal.Update(user);
            new EmailManager().SendEmailForNewPasswordLink(email, user.KeyCode);
        }
    }
}
