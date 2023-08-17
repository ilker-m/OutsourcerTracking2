using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Models.EmployeeHomeModels;

namespace OutsourcerTracking.Controllers.Homes
{
    [Authorize(Roles = "Employee User,Admin")]
    public class EmployeeHomeController : Controller
    {
        public readonly IOutsourceWorkOrderService _outsourceWorkOrderService;
        public readonly ISituationService _situationService;
        public readonly IReceiveService _receiveService;
        public readonly IEmployeeUserService _employeeUserService;
        public readonly IOutsourceService _outsourceService;
        public readonly ITrackingService _trackingService;
        public EmployeeHomeController(IOutsourceWorkOrderService outsourceWorkOrderService, ISituationService situationService, IReceiveService receiveService, IEmployeeUserService employeeUserService, IOutsourceService outsourceService, ITrackingService trackingService)
        {
            _outsourceWorkOrderService = outsourceWorkOrderService;
            _situationService = situationService;
            _receiveService = receiveService;
            _employeeUserService = employeeUserService;
            _outsourceService = outsourceService;
            _trackingService = trackingService;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Ana Sayfa";
            var model = new EmployeeHomeListViewModel
            {
                EmployeeHomeViewModelList = _outsourceWorkOrderService.GetForEmployeeTable()
            };
            return View(model);
        }
        [Route("employeehome/{ActionName}/{situationId:int}")]
        public IActionResult Index(int situationId)
        {
            ViewData["Title"] = _situationService.GetNameById(situationId);
            var model = new EmployeeHomeListViewModel
            {
                EmployeeHomeViewModelList = _outsourceWorkOrderService.GetBySituationIdForEmployeeTable(situationId)
            };
            return View(model);
        }
        public IActionResult AddReceive(int outsourceWorkOrderId)
        {
            List<SelectListItem> employeeList = _employeeUserService.GetTransporterNames().Select(eu => new SelectListItem { Value = eu.Id.ToString(), Text = eu.FirstName + " " + eu.LastName }).ToList();
            ViewBag.employees = employeeList;
            var model = _outsourceWorkOrderService.GetToAddReciveById(outsourceWorkOrderId, HttpContext.User.Identity.Name);
            return View(model);
        }
        [HttpPost]
        public IActionResult AddReceive(EmployeeHomeAddReceiveViewModel addVM)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> employeeList = _employeeUserService.GetTransporterNames().Select(eu => new SelectListItem { Value = eu.Id.ToString(), Text = eu.FirstName + " " + eu.LastName }).ToList();
                ViewBag.employees = employeeList;
                return View(addVM);
            }
            var result = _receiveService.AddReceiveFromEmployeeHome(addVM, HttpContext.User.Identity.Name);
            if (!result.Success)
            {
                List<SelectListItem> employeeList = _employeeUserService.GetTransporterNames().Select(eu => new SelectListItem { Value = eu.Id.ToString(), Text = eu.FirstName + " " + eu.LastName }).ToList();
                ViewBag.employees = employeeList;
                TempData["msg"] = result.Message;
                return View(addVM);
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult EditReceive(int outsourceWorkOrderId)
        {
            var any = _receiveService.AnyNotSealedByOutsourceWorkOrderId(outsourceWorkOrderId);
            if(!any)
            {
                return RedirectToAction(nameof(Index));
            }
            var model = _outsourceWorkOrderService.GetToEditReciveById(outsourceWorkOrderId);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            List<SelectListItem> employeeList = _employeeUserService.GetTransporterNames().Select(eu => new SelectListItem { Value = eu.Id.ToString(), Text = eu.FirstName + " " + eu.LastName }).ToList();
            ViewBag.employees = employeeList;
            return View(model);
        }
        [HttpPost]
        public IActionResult EditReceive(EmployeeHomeEditReceiveViewModel editVM)
        {
            var any = _receiveService.AnyNotSealedByOutsourceWorkOrderId(editVM.OutsourceWorkOrderId);
            if(!any)
            {
                TempData["msg"] = "30 Dakika geçildiği için Düzeltme Yapılamaz!";
                List<SelectListItem> employeeList = _employeeUserService.GetTransporterNames().Select(eu => new SelectListItem { Value = eu.Id.ToString(), Text = eu.FirstName + " " + eu.LastName }).ToList();
                ViewBag.employees = employeeList;
                return View(editVM);
            }
            if(!ModelState.IsValid)
            {
                List<SelectListItem> employeeList = _employeeUserService.GetTransporterNames().Select(eu => new SelectListItem { Value = eu.Id.ToString(), Text = eu.FirstName + " " + eu.LastName }).ToList();
                ViewBag.employees = employeeList;
                return View(editVM);
            }
            var result = _receiveService.EditReceiveFromEmployeeHome(editVM, HttpContext.User.Identity.Name);
            if (!result.Success)
            {
                TempData["msg"] = result.Message;
                List<SelectListItem> employeeList = _employeeUserService.GetTransporterNames().Select(eu => new SelectListItem { Value = eu.Id.ToString(), Text = eu.FirstName + " " + eu.LastName }).ToList();
                ViewBag.employees = employeeList;
                return View(editVM);
            }
            //_outsourceWorkOrderService.SetSituation(editVM.OutsourceWorkOrderId);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult DeleteReceive(int receiveId, int outsourceWorkOrderId)
        {
            _receiveService.Delete(receiveId, HttpContext.User.Identity.Name);
            //_outsourceWorkOrderService.SetSituation(outsourceWorkOrderId);
            return RedirectToAction(nameof(Index));
        }
        public JsonResult GetOutsourceDetail(int outsourceId)
        {
            var outsource = _outsourceService.GetById(outsourceId);
            return Json(outsource);
        }
        public JsonResult GetTrackingsDetail(int outsourceWorkOrderId)
        {
            var trackings = _trackingService.GetListByOutsourceWorkOrderId(outsourceWorkOrderId);
            return Json(trackings);
        }
        public JsonResult GetReceivesDetail(int outsourceWorkOrderId)
        {
            var receives = _receiveService.GetAllByOutsourceWorkOrderId(outsourceWorkOrderId);
            return Json(receives);
        }
        

    }
}
