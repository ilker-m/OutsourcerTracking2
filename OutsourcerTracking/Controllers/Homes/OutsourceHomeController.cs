using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Models.OutsourceHomeModels;

namespace OutsourcerTracking.Controllers.Homes
{
    [Authorize(Roles = "Outsource User, Admin")]
    public class OutsourceHomeController : Controller
    {
        private readonly IOutsourceWorkOrderService _outsourceWorkOrderService;
        public readonly IOutsourceService _outsourceService;
        private readonly IReceiveService _receiveService;
        private readonly ITrackingService _trackingService;
        private readonly IEmailService _emailService;
        public OutsourceHomeController(IOutsourceWorkOrderService outsourceWorkOrderService, IOutsourceService outsourceService, IReceiveService receiveService, ITrackingService trackingService, IEmailService emailService)
        {
            _outsourceWorkOrderService = outsourceWorkOrderService;
            _outsourceService = outsourceService;
            _receiveService = receiveService;
            _trackingService = trackingService;
            _emailService = emailService;
        }
        [Authorize(Roles = "Outsource User")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Ana Sayfa";
            var model = new OutsourceHomeListViewModel
            {
                OutsourceHomeViewModels = _outsourceWorkOrderService.GetForOutsourceTableByUserName(HttpContext.User.Identity.Name)
            };
            return View(model);
        }
        [Route("outsourcehome/{ActionName}/{outsourceId:int}")]
        public IActionResult Index(int outsourceId)
        {
            ViewData["Title"] = _outsourceService.GetNameById(outsourceId);
            var model = new OutsourceHomeListViewModel
            {
                OutsourceHomeViewModels = _outsourceWorkOrderService.GetForOutsourceTableByOutsourceId(outsourceId)
            };
            return View(model);
        }
        [Authorize(Roles = "Outsource User")]
        public IActionResult AddTracking(int outsourceWorkOrderId)
        {
            var model = _outsourceWorkOrderService.GetToAddTrackingById(outsourceWorkOrderId);
            return View(model);
        }
        [Authorize(Roles = "Outsource User")]
        [HttpPost]
        public IActionResult AddTracking(OutsourceHomeAddTrackingViewModel addVM)
        {
            if(!ModelState.IsValid) 
            { 
                return View(addVM);
            }
            var result = _trackingService.AddTrackingFromOutsourceHome(addVM, HttpContext.User.Identity.Name);
            if (!result.Success)
            {
                TempData["msg"] = result.Message;
                return View(addVM);
            }
            _outsourceWorkOrderService.SetSituation(addVM.OutsourceWorkOrderId);
            _emailService.SendEmailToEmployeesAboutAddedProduct(addVM.OutsourceWorkOrderId);
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Outsource User")]
        public IActionResult EditTracking(int outsourceWorkOrderId)
        {
            var any = _trackingService.AnyNotSealedByOutsourceWorkOrderId(outsourceWorkOrderId);
            if(!any)
            {
                return RedirectToAction(nameof(Index));
            }
            var model = _outsourceWorkOrderService.GetToEditTrackingById(outsourceWorkOrderId);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Outsource User")]
        public IActionResult EditTracking(OutsourceHomeEditTrackingViewModel editVM)
        {
            var any = _trackingService.AnyNotSealedByOutsourceWorkOrderId(editVM.OutsourceWorkOrderId);
            if (!any)
            {
                TempData["msg"] = "30 Dakika geçildiği için Düzeltme Yapılamaz!";
                return View(editVM);
            }
            if (!ModelState.IsValid)
            {
                return View(editVM);
            }
            var result = _trackingService.EditTrackingFromOutsourceHome(editVM, HttpContext.User.Identity.Name);
            if (!result.Success)
            {
                TempData["msg"] = result.Message;
                return View(editVM);
            }
            _outsourceWorkOrderService.SetSituation(editVM.OutsourceWorkOrderId);
            _emailService.SendEmailToEmployeesAboutEditedProduct(editVM.OutsourceWorkOrderId);
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Outsource User")]
        public IActionResult DeleteTracking(int trackingId, int outsourceWorkOrderId)
        {
            _trackingService.Delete(trackingId, HttpContext.User.Identity.Name);
            _outsourceWorkOrderService.SetSituation(outsourceWorkOrderId);
            _emailService.SendEmailToEmployeesAboutDeletedProduct(outsourceWorkOrderId);
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Outsource User")]
        public IActionResult MakeCompleted(int outsourceWorkOrderId)
        {
            _outsourceWorkOrderService.MakeCompleted(outsourceWorkOrderId, HttpContext.User.Identity.Name);
            return RedirectToAction(nameof(Index));
        }
        public JsonResult GetReceivesDetail(int outsourceWorkOrderId)
        {
            var receives = _receiveService.GetAllByOutsourceWorkOrderId(outsourceWorkOrderId);
            return Json(receives);
        }
        public JsonResult GetTrackingsDetail(int outsourceWorkOrderId)
        {
            var trackings = _trackingService.GetListByOutsourceWorkOrderId(outsourceWorkOrderId);
            return Json(trackings);
        }
    }
}
