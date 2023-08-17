using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Models.EmployeeUserModels;
using System.Data;

namespace OutsourcerTracking.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeeUserController : Controller
    {
        private readonly IEmployeeUserService _employeeUserService;
        private readonly IRoleService _roleService;
        private readonly IDepartmentService _departmentService;
        private readonly ITitleService _titleService;
        public EmployeeUserController(IEmployeeUserService employeeUserService, IRoleService roleService, IDepartmentService departmentService, ITitleService titleService)
        {
            _employeeUserService = employeeUserService;
            _roleService = roleService;
            _departmentService = departmentService;
            _titleService = titleService;
        }
        public IActionResult Index()
        {
            var model = new EmployeeUserListViewModel
            {
                EmployeeUsers = _employeeUserService.GetAllFullRelation()
            };
            return View(model);
        }
        public IActionResult Create()
        {
            List<SelectListItem> roleList = _roleService.GetAllEmployeeRoles().ToList().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Name }).ToList();
            ViewBag.roles = roleList;
            List<SelectListItem> departmanList = _departmentService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name }).ToList();
            ViewBag.departments = departmanList;
            List<SelectListItem> titleList = _titleService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name }).ToList();
            ViewBag.titles = titleList;
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeUserCreateViewModel createVM)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> roleList = _roleService.GetAllEmployeeRoles().ToList().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Name }).ToList();
                ViewBag.roles = roleList;
                List<SelectListItem> departmanList = _departmentService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name }).ToList();
                ViewBag.departments = departmanList;
                List<SelectListItem> titleList = _titleService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name }).ToList();
                ViewBag.titles = titleList;
                return View(createVM);
            }
            _employeeUserService.AddRelational(createVM, HttpContext.User.Identity.Name);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int Id)
        {
            List<SelectListItem> roleList = _roleService.GetAllEmployeeRoles().ToList().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Name }).ToList();
            ViewBag.roles = roleList;
            List<SelectListItem> departmanList = _departmentService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name }).ToList();
            ViewBag.departments = departmanList;
            List<SelectListItem> titleList = _titleService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name }).ToList();
            ViewBag.titles = titleList;
            var updateEmployeeUser = _employeeUserService.GetRealtionalById(Id);
            return View(updateEmployeeUser);
        }
        [HttpPost]
        public IActionResult Edit(EmployeeUserEditViewModel editVM)
        {
            if(!ModelState.IsValid)
            {
                List<SelectListItem> roleList = _roleService.GetAllEmployeeRoles().ToList().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.Name }).ToList();
                ViewBag.roles = roleList;
                List<SelectListItem> departmanList = _departmentService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name }).ToList();
                ViewBag.departments = departmanList;
                List<SelectListItem> titleList = _titleService.GetAll().Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name }).ToList();
                ViewBag.titles = titleList;
                return View(editVM);
            }
            _employeeUserService.EditRelational(editVM, HttpContext.User.Identity.Name);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            _employeeUserService.Delete(id, HttpContext.User.Identity.Name);
            return RedirectToAction(nameof(Index));
        }
    }
}
