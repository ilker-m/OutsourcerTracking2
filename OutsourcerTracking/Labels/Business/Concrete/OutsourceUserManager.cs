using Microsoft.AspNetCore.Identity;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.EmployeeUserModels;
using OutsourcerTracking.Models.OutsouceUserModels;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class OutsourceUserManager : IOutsourceUserService
    {
        private readonly IOutsourceUserDal _outsourceUserDal;
        private readonly IUserDal _userDal;
        private readonly IUsersRolesDal _usersRolesDal;
        private readonly IOutsourcesOutsourceUsersDal _outsourcesOutsourceUsersDal;
        private readonly IRoleDal _roleDal;
        private readonly UserManager<User> _userManager;
        public OutsourceUserManager(IOutsourceUserDal outsourceUserDal, IUserDal userDal, IUsersRolesDal usersRolesDal, IOutsourcesOutsourceUsersDal outsourcesOutsourceUsersDal, IRoleDal roleDal, UserManager<User> userManager)
        {
            _outsourceUserDal = outsourceUserDal;
            _userDal = userDal;
            _usersRolesDal = usersRolesDal;
            _outsourcesOutsourceUsersDal = outsourcesOutsourceUsersDal;
            _roleDal = roleDal;
            _userManager = userManager;
        }
        public void AddRelational(OutsourceUserCreateViewModel viewModel, string currentUserName)
        {
            var user = new User
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                UserName = viewModel.FirstName + " " + viewModel.LastName,
                Email = viewModel.Email,
                LockoutEnabled = false,
                PhoneNumber = viewModel.Phone,
                IsActive = true,
                IsFirst = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                CreatedOn = DateTime.Now,
                CreatedBy = currentUserName
            };
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, viewModel.Password);
            _userDal.Add(user);
            int lastId = _userDal.GetLastUserId();
            var outsourceUser = new OutsourceUser
            {
                Id = lastId,
            };
            _outsourceUserDal.Add(outsourceUser);
            var userRole = new UsersRoles
            {
                RoleId = viewModel.RoleId,
                UserId = lastId
            };
            _usersRolesDal.Add(userRole);
            var outsourcesOutsourceUser = new OutsourcesOutsourceUsers();
            outsourcesOutsourceUser.OutsourceUserId = lastId;
            foreach (var outsourceId in viewModel.OutsourceIds)
            {
                outsourcesOutsourceUser.OutsourceId = outsourceId;
                _outsourcesOutsourceUsersDal.Add(outsourcesOutsourceUser);
            }
        }
        public void Delete(int id, string currentUserName)
        {
            var user = _userDal.Get(u => u.Id == id);
            user.IsDeleted = true;
            user.UpdatedOn = DateTime.Now;
            user.UpdatedBy = currentUserName;
            _userDal.Update(user);
        }

        public void EditRelational(OutsourceUserEditViewModel viewModel, string currentUserName)
        {
            var user = _userDal.Get(u => u.Id == viewModel.Id);
            user.FirstName = viewModel.FirstName;
            user.LastName = viewModel.LastName;
            user.UserName = viewModel.FirstName + " " + viewModel.LastName;
            user.Email = viewModel.Email;
            user.LockoutEnabled = false;
            user.PhoneNumber = viewModel.Phone;
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.UpdatedOn = DateTime.Now;
            user.UpdatedBy = currentUserName;
            _userDal.Update(user);
            var usersroles = _usersRolesDal.Get(ur => ur.UserId == viewModel.Id);
            usersroles.RoleId = viewModel.RoleId;
            _usersRolesDal.Update(usersroles);
            _outsourcesOutsourceUsersDal.GetList(oou => oou.OutsourceUserId == viewModel.Id).ForEach(oou =>
            {
                _outsourcesOutsourceUsersDal.DeleteManuel(oou);
            });
            viewModel.OutsourceIds.ForEach(oId =>
            {
                _outsourcesOutsourceUsersDal.Add(new OutsourcesOutsourceUsers { OutsourceId = oId, OutsourceUserId = viewModel.Id});
            });
        }
        public List<OutsourceUserViewModel> GetAllFullRelation()
        {
            return _outsourceUserDal.GetAllFullRelation();
        }

        public OutsourceUserEditViewModel GetRealtionalById(int id)
        {
            return _outsourceUserDal.GetRelationalById(id);
        }
    }
}
