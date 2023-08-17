using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models;
using OutsourcerTracking.Models.UserAuthenticationModels;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<ResultViewModel<User>> LoginAsync(UserAuthenticationLoginViewModel loginVM);
        Task LogoutAsync();
        Task<ResultViewModel<User>> CheckAPIUserAsync(string base64);
        void ChangePassword(string userName, string password);
        Task<ResultViewModel<ForgetPasswordModel>> CheckEmail(string email);
        void RecordKeyCode(string email);

        ResultViewModel<User> ChangePasswordWithKeyCode(string KeyCode, string password);
    }
}
