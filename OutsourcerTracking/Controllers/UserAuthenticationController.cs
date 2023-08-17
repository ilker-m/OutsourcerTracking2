using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis;
using OutsourcerTracking.Controllers.Homes;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.Business.Concrete;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.UserAuthenticationModels;

namespace OutsourcerTracking.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private readonly IUserAuthenticationService _userAuthenticationService;



        public UserAuthenticationController(IUserAuthenticationService userAuthenticationService)
        {
            _userAuthenticationService = userAuthenticationService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserAuthenticationLoginViewModel loginVM) 
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            var result = await _userAuthenticationService.LoginAsync(loginVM);
            if(result.Success)
            {
                if (result.Object.IsFirst)
                    return RedirectToAction(nameof(UserAuthenticationController.ChangePassword), nameof(UserAuthenticationController).Replace("Controller", ""));
                else
                    return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
            }
            else
            {
                TempData["msg"] = result.Message;
                return RedirectToAction(nameof(Login));
            }
        }
        public async Task<IActionResult> LogoutAsync()
        {
            await _userAuthenticationService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }
        public async Task<IActionResult> ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel changePasswordModel)
        {
            if (!ModelState.IsValid)
            {
                return View(changePasswordModel);
            }
            _userAuthenticationService.ChangePassword(HttpContext.User.Identity.Name, changePasswordModel.NewPassword);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
        }
        public async Task<IActionResult> ForgetPassword()
        {





            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordModel forgetPasswordModel)
        {
            if(!ModelState.IsValid)
            {
                return View(forgetPasswordModel);
            }
            var result = await _userAuthenticationService.CheckEmail(forgetPasswordModel.Email);
            if (result.Success)
            {

              _userAuthenticationService.RecordKeyCode(forgetPasswordModel.Email);
                return RedirectToAction(nameof(NewPassword));

            }
            else
            {
                TempData["msg"] = result.Message;
                return RedirectToAction(nameof(ForgetPassword));
            }
    
        }
        public async Task<IActionResult> NewPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewPassword(NewPasswordModel newPasswordModel)
        {
            if (!ModelState.IsValid)
            {
                return View(newPasswordModel);
            }
            else
            {

               var result= _userAuthenticationService.ChangePasswordWithKeyCode(newPasswordModel.key, newPasswordModel.newpassword);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Login));

                }
                else
                {
                    TempData["msg"] = result.Message;
                    return RedirectToAction(nameof(NewPassword));
                }
               
            }




        }
    }
}
