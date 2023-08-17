using Microsoft.AspNetCore.Mvc;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Models;
using OutsourcerTracking.Models.APIModels;
using System.Net;

namespace OutsourcerTracking.Controllers.WebAPIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationAPIController : ControllerBase
    {
        private readonly IUserAuthenticationService _userAuthenticationService;
        private readonly ITableService _tableService;
        private readonly IOutsourceWorkOrderService _outsourceWorkOrderService;
        private readonly IReceiveService _receiveService;
        private readonly IOutsourceService _outsoureService;
        public IntegrationAPIController(IUserAuthenticationService userAuthenticationService, ITableService tableService, IOutsourceWorkOrderService outsourceWorkOrderService, IReceiveService receiveService, IOutsourceService outsourceService)
        {
            _userAuthenticationService = userAuthenticationService;
            _tableService = tableService;
            _outsourceWorkOrderService = outsourceWorkOrderService;
            _receiveService = receiveService;
            _outsoureService = outsourceService;
        }
        [HttpGet]
        [Route("CheckChanges")]
        public async Task<IActionResult> CheckChanges([FromHeader(Name = "Authorization")] string authorization)
        {
            var result = await _userAuthenticationService.CheckAPIUserAsync(authorization);
            if (result.Success)
            {
                var isChanged = _tableService.CheckChanges();
                if(isChanged)
                {
                    return Ok();
                }
                return NoContent();
            }
            return Unauthorized(result.Message);
        }
        [HttpGet]
        [Route("GetChanges")]
        public async Task<IActionResult> GetChanges([FromHeader(Name = "Authorization")] string authorization)
        {
            var result = await _userAuthenticationService.CheckAPIUserAsync(authorization);
            if (result.Success)
            {
                return Ok(_outsourceWorkOrderService.GetChanges());
            }
            return Unauthorized(result.Message);
        }
        [HttpGet]
        [Route(nameof(GetWorkOrder))]
        public async Task<IActionResult> GetWorkOrder([FromHeader(Name = "Authorization")] string authorization, string workOrderNo)
        {
            var result = await _userAuthenticationService.CheckAPIUserAsync(authorization);
            if (result.Success)
            {
                return Ok(_outsourceWorkOrderService.GetWorkOrderNoByWorkOrderNo(workOrderNo));
            }
            return Unauthorized(result.Message);
        }
        [HttpGet]
        [Route(nameof(GetWorkOrdersBySituationId))]
        public async Task<IActionResult> GetWorkOrdersBySituationId([FromHeader(Name = "Authorization")] string authorization, int id)
        {
            var result = await _userAuthenticationService.CheckAPIUserAsync(authorization);
            if (result.Success)
            {
                return Ok(_outsourceWorkOrderService.GetWorkOrdersBySituationId(id));
            }
            return Unauthorized(result.Message);
        }
        [HttpPost]
        [Route(nameof(WorkOrder))]
        public async Task<IActionResult> WorkOrder([FromHeader(Name = "Authorization")] string authorization, AddEditWorkOrderModel addEditWorkOrderModel)
        {
            var result = await _userAuthenticationService.CheckAPIUserAsync(authorization);
            if (result.Success)
            {
                var outsourceWorkOrder = _outsourceWorkOrderService.GetByWorkOrderNo(addEditWorkOrderModel.WorkOrderNo);
                if (outsourceWorkOrder == null)
                {
                    var operationResult = _outsourceWorkOrderService.AddWorkOrder(addEditWorkOrderModel, result.Object.UserName);
                    if (operationResult.Success)
                    {
                        return Ok();
                    }
                    return BadRequest(operationResult.Message);
                }
                else
                {
                    var operationResult = _outsourceWorkOrderService.EditWorkOrder(addEditWorkOrderModel, outsourceWorkOrder, result.Object.UserName);
                    if (operationResult.Success)
                    {
                        return Ok();
                    }
                    return BadRequest(operationResult.Message);
                }
            }
            return Unauthorized(result.Message);
        }
        [HttpGet]
        [Route(nameof(GetWorkOrderDetails))]
        public async Task<IActionResult> GetWorkOrderDetails([FromHeader(Name = "Authorization")] string authorization, string workOrderNo)
        {
            var result = await _userAuthenticationService.CheckAPIUserAsync(authorization);
            if (result.Success)
            {
                return Ok(_outsourceWorkOrderService.GetDetailsByWorkOrderNo(workOrderNo));     
            }
            return Unauthorized(result.Message);
        }
        [HttpGet]
        [Route(nameof(TryToMakeFinish))]
        public async Task<IActionResult> TryToMakeFinish([FromHeader(Name = "Authorization")] string authorization, string workOrderNo)
        {
            var result = await _userAuthenticationService.CheckAPIUserAsync(authorization);
            if (result.Success)
            {
                var resultModel = _outsourceWorkOrderService.TryToMakeFinish(workOrderNo, result.Object.UserName);
                return resultModel.Success ? Ok() : BadRequest(resultModel.Message);
            }
            return Unauthorized(result.Message);
        }
        [HttpPut]
        [Route(nameof(ApproveReceivesByIds))]
        public async Task<IActionResult> ApproveReceivesByIds([FromHeader(Name = "Authorization")] string authorization, [FromBody] int[] ids)
        {
            var result = await _userAuthenticationService.CheckAPIUserAsync(authorization);
            if (result.Success)
            {
                _receiveService.ApproveReceivesByIds(ids, result.Object.UserName);
                return Ok();
            }
            return Unauthorized(result.Message);
        }
        [HttpPost]
        [Route(nameof(OutsourceUser))]
        public async Task<IActionResult> OutsourceUser([FromHeader(Name = "Authorization")] string authorization, [FromBody] AddEditOutsourceTrackingModel addEditOutsourceTrackingModel)
        {
            var result = await _userAuthenticationService.CheckAPIUserAsync(authorization);
            if (result.Success)
            {
                var outsource = _outsoureService.GetByCurrentCode(addEditOutsourceTrackingModel.CurrentCode);
                if (outsource == null)
                {
                    _outsoureService.AddWithUser(addEditOutsourceTrackingModel, result.Object.UserName);
                }
                else
                {
                    _outsoureService.EditWithUser(outsource!, addEditOutsourceTrackingModel, result.Object.UserName);
                }
                return Ok();
            }
            return Unauthorized(result.Message);
        }
    }

}
