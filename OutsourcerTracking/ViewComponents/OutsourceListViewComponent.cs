using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.ViewComponentModels;
using System.Security.Claims;

namespace OutsourcerTracking.ViewComponents
{
    public class OutsourceListViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;
        private readonly IOutsourceService _outsourceService;
        public OutsourceListViewComponent(UserManager<User> userManager, IOutsourceService outsourceService)
        {
            _userManager = userManager;
            _outsourceService = outsourceService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new OutsourceListViewComponentModel();
            if (HttpContext.User.IsInRole("Admin"))
            {
                model.Outsources = _outsourceService.GetAll();
            }
            else
            {
                User user = _userManager.GetUserAsync(HttpContext.User).Result;
                model.Outsources = _outsourceService.GetAllByOutsourceUserId(user.Id);
            }
            return View(model);
        }
    }
}
