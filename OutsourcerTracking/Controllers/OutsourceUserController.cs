using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Models.OutsouceUserModels;

namespace OutsourcerTracking.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OutsourceUserController : Controller
    {
        private readonly IOutsourceUserService _outsourceUserService;
        private readonly IRoleService _roleService;
        private readonly IOutsourceService _outsourceService;
        public OutsourceUserController(IOutsourceUserService outsourceUserService, IRoleService roleService, IOutsourceService outsourceService)
        {
            _outsourceUserService = outsourceUserService;
            _roleService = roleService;
            _outsourceService = outsourceService;
        }
        public IActionResult Index()
        {
            var model = new OutsourceUserListViewModel()
            {
                OutsourceUsers = _outsourceUserService.GetAllFullRelation()
            };
            return View(model);
        }
        public IActionResult Create()
        {
            List<SelectListItem> roleList = _roleService.GetAllOutsourceRoles().ToList().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Name }).ToList();
            ViewBag.roles = roleList;
            List<SelectListItem> outsourceList = _outsourceService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.MachineName }).ToList();
            ViewBag.outsources = outsourceList;
            return View();
        }
        [HttpPost]
        public IActionResult Create(OutsourceUserCreateViewModel createVM)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> roleList = _roleService.GetAllOutsourceRoles().ToList().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Name }).ToList();
                ViewBag.roles = roleList;
                List<SelectListItem> outsourceList = _outsourceService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.MachineName }).ToList();
                ViewBag.outsources = outsourceList;
                return View(createVM);
            }
            _outsourceUserService.AddRelational(createVM, HttpContext.User.Identity.Name);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            List<SelectListItem> roleList = _roleService.GetAllOutsourceRoles().ToList().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Name }).ToList();
            ViewBag.roles = roleList;
            List<SelectListItem> outsourceList = _outsourceService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.MachineName }).ToList();
            ViewBag.outsources = outsourceList;
            var model = _outsourceUserService.GetRealtionalById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(OutsourceUserEditViewModel editVM)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> roleList = _roleService.GetAllOutsourceRoles().ToList().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Name }).ToList();
                ViewBag.roles = roleList;
                List<SelectListItem> outsourceList = _outsourceService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.MachineName }).ToList();
                ViewBag.outsources = outsourceList;
                return View(editVM);
            }
            _outsourceUserService.EditRelational(editVM, HttpContext.User.Identity.Name);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            _outsourceUserService.Delete(id, HttpContext.User.Identity.Name);
            return RedirectToAction(nameof(Index));
        }
    }
}
