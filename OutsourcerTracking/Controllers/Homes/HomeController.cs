using Microsoft.AspNetCore.Mvc;
using OutsourcerTracking.Models;
using System.Diagnostics;
using OutsourcerTracking.Labels.Business.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace OutsourcerTracking.Controllers.Homes
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ITitleService _titleService;
        public HomeController(ITitleService titleService)
        {
            _titleService = titleService;
        }

        public IActionResult Index()
        {
            if (HttpContext.User.IsInRole("Admin"))
            {
                return RedirectToAction(nameof(EmployeeHomeController.Index), nameof(EmployeeHomeController).Replace("Controller", ""));
            }
            else if (HttpContext.User.IsInRole("Employee User"))
            {
                return RedirectToAction(nameof(EmployeeHomeController.Index), nameof(EmployeeHomeController).Replace("Controller", ""));
            }
            else if (HttpContext.User.IsInRole("Outsource User"))
            {
                return RedirectToAction(nameof(OutsourceHomeController.Index), nameof(OutsourceHomeController).Replace("Controller", ""));
            }
            else if(HttpContext.User.IsInRole("API User"))
            {
                return RedirectToAction(nameof(UserAuthenticationController.Login), nameof(UserAuthenticationController).Replace("Controller", ""));
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}