using Humanizer;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.Business.DTOs;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Labels.DataAccess.Enums;
using OutsourcerTracking.Models;
using OutsourcerTracking.Models.APIModels;
using OutsourcerTracking.Models.EmployeeHomeModels;
using OutsourcerTracking.Models.OutsourceHomeModels;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Dynamic;
using System.Net;
using System.Xml.Linq;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class OutsourceWorkOrderManager : IOutsourceWorkOrderService
    {
        public readonly IOutsourceWorkOrderDal _outsourceWorkOrderDal;
        public readonly ITrackingDal _trackingDal;
        public readonly IReceiveDal _receiveDal;
        public readonly IUserDal _userDal;
        public readonly ITrackingService _trackingService;
        public readonly IReceiveService _receiveService;
        public readonly IAlkWorkOrderService _alkWorkOrderService;
        public readonly IOutsourceService _outsourceService;
        public readonly IOperationService _operationService;
        public OutsourceWorkOrderManager(IOutsourceWorkOrderDal outsourceWorkOrderDal, ITrackingDal trackingDal, IReceiveDal receiveDal, IUserDal userDal, ITrackingService trackingService, IReceiveService receiveService, IAlkWorkOrderService alkWorkOrderService, IOutsourceService outsourceService, IOperationService operationService)
        {
            _outsourceWorkOrderDal = outsourceWorkOrderDal;
            _trackingDal = trackingDal;
            _receiveDal = receiveDal;
            _userDal = userDal;
            _trackingService = trackingService;
            _receiveService = receiveService;
            _alkWorkOrderService = alkWorkOrderService;
            _outsourceService = outsourceService;
            _operationService = operationService;
        }
        public List<EmployeeHomeViewModel> GetBySituationIdForEmployeeTable(int id)
        {
            _receiveService.SealByDate();
            var DTOs = _outsourceWorkOrderDal.GetForOutsourceTableBySituationId(id);
            return DTOs.Select(dto => new EmployeeHomeViewModel
            {
                OutsourceWorkOrderId = dto.Id,
                AlkWorkOrderId = dto.AlkWorkOrderId,
                ReferenceWorkOrder = dto.ReferenceWorkOrder,
                OrderGroup = dto.OrderGroup,
                StockCode = dto.StockCode,
                OutsourceId = dto.OutsourceId,
                OutsourceName = dto.OutsourceName,
                SituationId = dto.SituationId,
                SituationName = dto.SituationName,
                ColorCode = dto.ColorCode,
                ColorName = dto.ColorName,
                WorkOrderNo = dto.WorkOrderNo,
                Deadline = dto.Deadline,
                Amount = dto.Amount,
                TotalProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                TotalReceivedAmount = _receiveDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                IsReceiveEditable = _receiveDal.AnyNotSealedByOutsourceWorkOrderId(dto.Id)
            }).ToList();
        }
        public List<EmployeeHomeViewModel> GetForEmployeeTable()
        {
            _receiveService.SealByDate();
            var DTOs = _outsourceWorkOrderDal.GetForEmployeeTable();
            return DTOs.Select(dto => new EmployeeHomeViewModel
            {
                OutsourceWorkOrderId = dto.Id,
                AlkWorkOrderId = dto.AlkWorkOrderId,
                ReferenceWorkOrder = dto.ReferenceWorkOrder,
                OrderGroup = dto.OrderGroup,
                StockCode = dto.StockCode,
                OutsourceId = dto.OutsourceId,
                OutsourceName = dto.OutsourceName,
                SituationId = dto.SituationId,
                SituationName = dto.SituationName,
                ColorCode = dto.ColorCode,
                ColorName = dto.ColorName,
                WorkOrderNo = dto.WorkOrderNo,
                Deadline = dto.Deadline,
                Amount = dto.Amount,
                TotalProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                TotalReceivedAmount = _receiveDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                IsReceiveEditable = _receiveDal.AnyNotSealedByOutsourceWorkOrderId(dto.Id)
            }).ToList();
        }
        public EmployeeHomeViewModel GetForEmployeeTableById(int id)
        {
            var dto = _outsourceWorkOrderDal.GetForEmployeeTableById(id);
            return new EmployeeHomeViewModel
            {
                OutsourceWorkOrderId = dto.Id,
                AlkWorkOrderId = dto.AlkWorkOrderId,
                ReferenceWorkOrder = dto.ReferenceWorkOrder,
                OrderGroup = dto.OrderGroup,
                StockCode = dto.StockCode,
                OutsourceId = dto.OutsourceId,
                OutsourceName = dto.OutsourceName,
                SituationId = dto.SituationId,
                SituationName = dto.SituationName,
                ColorCode = dto.ColorCode,
                ColorName = dto.ColorName,
                WorkOrderNo = dto.WorkOrderNo,
                Deadline = dto.Deadline,
                Amount = dto.Amount,
                TotalProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                TotalReceivedAmount = _receiveDal.GetTotalByOutsourceWorkOrderId(dto.Id),
            };
        }
        public EmployeeHomeAddReceiveViewModel GetToAddReciveById(int id, string currentUser)
        {
            _receiveService.SealByDate();
            var dto = _outsourceWorkOrderDal.GetToAddReciveById(id);
            var totalProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.OutsourceWorkOrderId);
            var totalReceivedAmount = _receiveDal.GetTotalByOutsourceWorkOrderId(dto.OutsourceWorkOrderId);
            return new EmployeeHomeAddReceiveViewModel
            {
                OutsourceWorkOrderId = dto.OutsourceWorkOrderId,
                ReferenceWorkOrder = dto.ReferenceWorkOrder,
                WorkOrderNo = dto.WorkOrder,
                OrderGroup = dto.OrderGroup,
                StockCode = dto.StockCode,
                EmployeeUserId = _userDal.Get(u => u.UserName == currentUser).Id,
                WillProduceTotalAmount = dto.WillProduceTotalAmount,
                TotalProducedAmount = totalProducedAmount,
                TotalReceivedAmount = totalReceivedAmount,
                ReceivableAmount = totalProducedAmount - totalReceivedAmount,
                Date = DateTime.Now
            };
        }
        public EmployeeHomeEditReceiveViewModel GetToEditReciveById(int id)
        {
            _receiveService.SealByDate(id);
            var dto = _outsourceWorkOrderDal.GetToEditReciveById(id);
            var totalProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.OutsourceWorkOrderId);
            var totalReceivedAmount = _receiveDal.GetTotalByOutsourceWorkOrderId(dto.OutsourceWorkOrderId);
            return new EmployeeHomeEditReceiveViewModel
            {
                Id = dto.Id,
                OutsourceWorkOrderId = dto.OutsourceWorkOrderId,
                ReferenceWorkOrder = dto.ReferenceWorkOrder,
                WorkOrder = dto.WorkOrder,
                OrderGroup = dto.OrderGroup,
                StockCode = dto.StockCode,
                WillProduceTotalAmount = dto.WillProduceTotalAmount,
                TotalProducedAmount = totalProducedAmount,
                TotalReceivedAmount = totalReceivedAmount,
                ReceivableAmount = totalProducedAmount - totalReceivedAmount,
                Date = dto.Date,
                EmployeeUserId = dto.EmployeeUserId,
                Amount = dto.Amount,
                AmountAgain = dto.AmountAgain,
            };
        }
        public List<OutsourceHomeViewModel> GetForOutsourceTableByUserName(string name)
        {
            var userId = _userDal.Get(u => u.UserName == name).Id;
            var DTOs = _outsourceWorkOrderDal.GetForOutsourceTableByUserId(userId);
            _trackingService.SealByDate();
            return DTOs.Select(dto => new OutsourceHomeViewModel
            {
                OutsourceWorkOrderId = dto.Id,
                AlkWorkOrderId = dto.AlkWorkOrderId,
                ReferenceWorkOrder = dto.ReferenceWorkOrder,
                OrderGroup = dto.OrderGroup,
                StockCode = dto.StockCode,
                OutsourceId = dto.OutsourceId,
                OutsourceName = dto.OutsourceName,
                ColorCode = dto.ColorCode,
                ColorName = dto.ColorName,
                WorkOrderNo = dto.WorkOrderNo,
                Deadline = dto.Deadline,
                Amount = dto.Amount,
                SituationId = dto.SituationId,
                SituationName = dto.SituationName,
                TotalProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                TotalReceivedAmount = _receiveDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                IsTrackingEditable = _trackingDal.AnyNotSealedByOutsourceWorkOrderId(dto.Id)
            }).ToList();
        }
        public List<OutsourceHomeViewModel> GetForOutsourceTableByOutsourceId(int id)
        {
            _trackingService.SealByDate();
            var DTOs = _outsourceWorkOrderDal.GetForTableByOutsourceId(id);
            return DTOs.Select(dto => new OutsourceHomeViewModel
            {
                OutsourceWorkOrderId = dto.Id,
                AlkWorkOrderId = dto.AlkWorkOrderId,
                ReferenceWorkOrder = dto.ReferenceWorkOrder,
                OrderGroup = dto.OrderGroup,
                StockCode = dto.StockCode,
                OutsourceId = dto.OutsourceId,
                OutsourceName = dto.OutsourceName,
                SituationId = dto.SituationId,
                SituationName = dto.SituationName,
                ColorCode = dto.ColorCode,
                ColorName = dto.ColorName,
                WorkOrderNo = dto.WorkOrderNo,
                Deadline = dto.Deadline,
                Amount = dto.Amount,
                TotalProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                TotalReceivedAmount = _receiveDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                IsTrackingEditable = _trackingDal.AnyNotSealedByOutsourceWorkOrderId(dto.Id)
            }).ToList();
        }
        public OutsourceHomeAddTrackingViewModel GetToAddTrackingById(int id)
        {
            _trackingService.SealByDate();
            var dto = _outsourceWorkOrderDal.GetToAddTrakingById(id);
            decimal totalProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.OutsourceWorkOrderId);
            return new OutsourceHomeAddTrackingViewModel
            {
                OutsourceWorkOrderId = dto.OutsourceWorkOrderId,
                ReferenceWorkOrder = dto.ReferenceWorkOrder,
                WorkOrderNo = dto.WorkOrder,
                OrderGroup = dto.OrderGroup,
                StockCode = dto.StockCode,
                WillPoduceTotalAmount = dto.WillPoduceTotalAmount,
                TotalProducedAmount = totalProducedAmount,
                WillProduceAmount = dto.WillPoduceTotalAmount - totalProducedAmount,
                Date = DateTime.Now,
            };
        }
        public OutsourceHomeEditTrackingViewModel GetToEditTrackingById(int id)
        {
            _trackingService.SealByDate(id);
            var dto = _outsourceWorkOrderDal.GetToEditTrackingById(id);
            decimal totalProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.OutsourceWorkOrderId);
            return new OutsourceHomeEditTrackingViewModel
            {
                Id = dto.Id,
                OutsourceWorkOrderId = dto.OutsourceWorkOrderId,
                ReferenceWorkOrder = dto.ReferenceWorkOrder,
                WorkOrder = dto.WorkOrder,
                OrderGroup = dto.OrderGroup,
                StockCode = dto.StockCode,
                WillPoduceTotalAmount = dto.WillPoduceTotalAmount,
                Amount = dto.Amount,
                AmountAgain = dto.AmountAgain,
                Weight_Kg = dto.Weight_Kg,
                Weight_KgAgain = dto.Weight_KgAgain,
                TotalProducedAmount = totalProducedAmount,
                WillProduceAmount = dto.WillPoduceTotalAmount - totalProducedAmount,
                Date = dto.Date,
            };
        }
        public void SetSituation(int id)
        {
            var outsourceWorkOrder = _outsourceWorkOrderDal.Get(q => q.Id == id);
            decimal amount = outsourceWorkOrder.Amount;
            decimal producedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(id);
            if(producedAmount > 0)
            {
                outsourceWorkOrder.SituationId = (int)SituationEnum.Producing;
            }
            else if(producedAmount == 0)
            {
                outsourceWorkOrder.SituationId = (int)SituationEnum.OnHold;
            }
            _outsourceWorkOrderDal.Update(outsourceWorkOrder);
        }

        public List<OutsourceWorkOrder> GetAll()
        {
            return _outsourceWorkOrderDal.GetList(owo => !owo.IsDeleted);
        }

        public OutsourceWorkOrder GetById(int id)
        {
            return _outsourceWorkOrderDal.Get(owa => owa.Id == id);
        }

        public void Add(OutsourceWorkOrder outsourceWorkOrder, string currentUser)
        {
            outsourceWorkOrder.CreatedBy = currentUser;
            outsourceWorkOrder.CreatedOn = DateTime.Now;
            _outsourceWorkOrderDal.Add(outsourceWorkOrder);
        }

        public void Edit(OutsourceWorkOrder outsourceWorkOrder, string currentUser)
        {
            var oldOutsourceWorkOrder = _outsourceWorkOrderDal.Get(o => o.Id == outsourceWorkOrder.Id);
            outsourceWorkOrder.CreatedBy = oldOutsourceWorkOrder.CreatedBy;
            outsourceWorkOrder.CreatedOn = oldOutsourceWorkOrder.CreatedOn;
            outsourceWorkOrder.UpdatedBy = currentUser;
            outsourceWorkOrder.UpdatedOn = DateTime.Now;
            _outsourceWorkOrderDal.Update(outsourceWorkOrder);
        }

        public void Delete(int id, string currentUser)
        {
            var address = _outsourceWorkOrderDal.Get(o => o.Id == id);
            address.UpdatedBy = currentUser;
            address.UpdatedOn = DateTime.Now;
            address.IsDeleted = true;
            _outsourceWorkOrderDal.Update(address);
        }

        public OutsourceWorkOrder GetByWorkOrderNo(string workOrder)
        {
            return _outsourceWorkOrderDal.Get(owo => owo.WorkOrderNo == workOrder.Trim());
        }

        public List<OutsourceWorkOrderIntegrationModel> GetChanges()
        {
            var models = new List<OutsourceWorkOrderIntegrationModel>();
            var DTOs = _outsourceWorkOrderDal.GetChanges();
            return DTOs.Select(dto => new OutsourceWorkOrderIntegrationModel
            {
                Isemrino = dto.Isemrino,
                Refisemrino = dto.Refisemrino,
                Aciklama = dto.Aciklama,
                Hmdepokodu = dto.Hmdepokodu,
                Mamuldepokodu = dto.Mamuldepokodu,
                Opno = dto.Opno,
                Opkodu = dto.Opkodu,
                MakinaNo = dto.MakinaNo,
                Takipno = dto.Takipno,
                Miktar = dto.Miktar,
                StokKodu = dto.StokKodu,
                StokAdi = dto.StokAdi,
                Uretilen = _receiveDal.GetTotalByOutsourceWorkOrderId(dto.Takipno),//teslim alınana öncelik verilmiştir
                Istkodu = dto.Istkodu,
                Kayittarihi = dto.Kayittarihi,
                Isemritarihi = dto.Isemritarihi,
                TeslimTarihi = dto.TeslimTarihi,
                Kapatildi = dto.SituationId == (int)SituationEnum.Completed ? "E" : "H",
                IntegrationStatusId = dto.IntegrationStatusId,
            }).ToList();
        }

        public ResultViewModel<AddEditWorkOrderModel> AddWorkOrder(AddEditWorkOrderModel addEditWorkOrderModel, string currentUser)
        {
            var alkWorkOrder = _alkWorkOrderService.GetByReferenceWorkOrderNo(addEditWorkOrderModel.ReferenceWorkOrderNo);
            int? alkWorkOrderId = alkWorkOrder?.Id;
            if (alkWorkOrderId is null)
            {
                alkWorkOrderId = _alkWorkOrderService.Add(new AlkWorkOrder
                {
                    ReferenceWorkOrderNo = addEditWorkOrderModel.ReferenceWorkOrderNo,
                    OrderGroup = addEditWorkOrderModel.OrderGroup,
                    StockCode = addEditWorkOrderModel.StockCode,
                    StockName = addEditWorkOrderModel.StockName
                }, currentUser);
            }
            else
            {
                alkWorkOrder.OrderGroup = addEditWorkOrderModel.OrderGroup;
                alkWorkOrder.StockCode = addEditWorkOrderModel.StockCode;
                alkWorkOrder.StockName = addEditWorkOrderModel.StockName;
                _alkWorkOrderService.Edit(alkWorkOrder, currentUser);
            }
            var outsource = _outsourceService.GetByCurrentCode(addEditWorkOrderModel.CurrentCode);
            int? outsourceId = outsource?.Id;
            if (outsourceId is null)
                return new ResultViewModel<AddEditWorkOrderModel> { Success = false, Message = "Cari Kod kayıtlı değil.", Object = addEditWorkOrderModel };
            int? operationId = _operationService.GetByNo(addEditWorkOrderModel.OpNo)?.Id;
            if(operationId is null)
                return new ResultViewModel<AddEditWorkOrderModel> { Success = false, Message = "Operasyon Kodu kayıtlı değil.", Object = addEditWorkOrderModel };
            Add(new OutsourceWorkOrder
            {
                Description = addEditWorkOrderModel.Description,
                RawMaterialsWarehouseCode = addEditWorkOrderModel.RawMaterialsWarehouseCode,
                ProductWarehouseCode = addEditWorkOrderModel.ProductWarehouseCode,
                AlkWorkOrderId = (int)alkWorkOrderId,
                OutsourceId = (int)outsourceId,
                OperationId = (int)operationId,
                SituationId = (int)SituationEnum.OnHold,
                IntegrationStatusId = (int)IntegrationsStatusEnum.Add,
                WorkOrderNo = addEditWorkOrderModel.WorkOrderNo,
                Amount = addEditWorkOrderModel.Amount,
                RecordDate = addEditWorkOrderModel.RecordDate,
                WorkOrderDate = addEditWorkOrderModel.WorkOrderDate,
                ReceivedDate = addEditWorkOrderModel.ReceivedDate,
                AlkUserName = addEditWorkOrderModel.AlkUserName,
                AlkNormalizedUserName = addEditWorkOrderModel.AlkNormalizedUserName,
                Deadline = addEditWorkOrderModel.Deadline,
                ColorCode = addEditWorkOrderModel.ColorCode,
                ColorName = addEditWorkOrderModel.ColorName,
            }, currentUser);
            new EmailManager().SendEmailToEmployeesAboutAddedWorkOrder(new WorkOrderEmailModel
            {
                AlkNormalizedUserName = addEditWorkOrderModel.AlkNormalizedUserName,
                StockCode = addEditWorkOrderModel.StockCode,
                Amount = addEditWorkOrderModel.Amount,
                MachineName = outsource!.MachineName,
                WorkOrderNo = addEditWorkOrderModel.WorkOrderNo
            });
            return new ResultViewModel<AddEditWorkOrderModel> { Success = true, Message = "", Object = addEditWorkOrderModel };
        }
        public ResultViewModel<AddEditWorkOrderModel> EditWorkOrder(AddEditWorkOrderModel addEditWorkOrderModel, OutsourceWorkOrder outsourceWorkOrder, string currentUser)
        {
            var alkWorkOrder = _alkWorkOrderService.GetByReferenceWorkOrderNo(addEditWorkOrderModel.ReferenceWorkOrderNo);
            int? alkWorkOrderId = alkWorkOrder?.Id;
            if (alkWorkOrderId is null)
            {
                alkWorkOrderId = _alkWorkOrderService.Add(new AlkWorkOrder
                {
                    ReferenceWorkOrderNo = addEditWorkOrderModel.ReferenceWorkOrderNo,
                    OrderGroup = addEditWorkOrderModel.OrderGroup,
                    StockCode = addEditWorkOrderModel.StockCode,
                    StockName = addEditWorkOrderModel.StockName
                }, currentUser);
            }
            else
            {
                alkWorkOrder.OrderGroup = addEditWorkOrderModel.OrderGroup;
                alkWorkOrder.StockCode = addEditWorkOrderModel.StockCode;
                alkWorkOrder.StockName = addEditWorkOrderModel.StockName;
                _alkWorkOrderService.Edit(alkWorkOrder, currentUser);
            }
            var outsource = _outsourceService.GetByCurrentCode(addEditWorkOrderModel.CurrentCode);
            int? outsourceId = outsource?.Id;
            if (outsourceId is null)
                return new ResultViewModel<AddEditWorkOrderModel> { Success = false, Message = "Cari Kod kayıtlı değil.", Object = addEditWorkOrderModel };
            int? operationId = _operationService.GetByNo(addEditWorkOrderModel.OpNo)?.Id;
            if (operationId is null)
                return new ResultViewModel<AddEditWorkOrderModel> { Success = false, Message = "Operasyon Kodu kayıtlı değil.", Object = addEditWorkOrderModel };
            outsourceWorkOrder.Description = addEditWorkOrderModel.Description;
            outsourceWorkOrder.RawMaterialsWarehouseCode = addEditWorkOrderModel.RawMaterialsWarehouseCode;
            outsourceWorkOrder.ProductWarehouseCode = addEditWorkOrderModel.ProductWarehouseCode;
            outsourceWorkOrder.AlkWorkOrderId = (int)alkWorkOrderId;
            outsourceWorkOrder.OutsourceId = (int)outsourceId;
            outsourceWorkOrder.OperationId = (int)operationId;
            outsourceWorkOrder.SituationId = (int)SituationEnum.OnHold;
            outsourceWorkOrder.IntegrationStatusId = (int)IntegrationsStatusEnum.Add;
            outsourceWorkOrder.WorkOrderNo = addEditWorkOrderModel.WorkOrderNo;
            outsourceWorkOrder.Amount = addEditWorkOrderModel.Amount;
            outsourceWorkOrder.RecordDate = addEditWorkOrderModel.RecordDate;
            outsourceWorkOrder.WorkOrderDate = addEditWorkOrderModel.WorkOrderDate;
            outsourceWorkOrder.ReceivedDate = addEditWorkOrderModel.ReceivedDate;
            outsourceWorkOrder.AlkUserName = addEditWorkOrderModel.AlkUserName;
            outsourceWorkOrder.AlkNormalizedUserName = addEditWorkOrderModel.AlkNormalizedUserName;
            outsourceWorkOrder.Deadline = addEditWorkOrderModel.Deadline;
            outsourceWorkOrder.ColorCode = addEditWorkOrderModel.ColorCode;
            outsourceWorkOrder.ColorName = addEditWorkOrderModel.ColorName;
            Edit(outsourceWorkOrder, currentUser);
            new EmailManager().SendEmailToEmployeesAboutEditedWorkOrder(new WorkOrderEmailModel
            {
                AlkNormalizedUserName = addEditWorkOrderModel.AlkNormalizedUserName,
                StockCode = addEditWorkOrderModel.StockCode,
                Amount = addEditWorkOrderModel.Amount,
                MachineName = outsource!.MachineName,
                WorkOrderNo = addEditWorkOrderModel.WorkOrderNo
            });
            return new ResultViewModel<AddEditWorkOrderModel> { Success = true, Message = "", Object = addEditWorkOrderModel };
        }

        public GetWorkOrderModel? GetWorkOrderNoByWorkOrderNo(string workOrderNo)
        {
            var dto = _outsourceWorkOrderDal.GetWorkOderByWorkOrderNo(workOrderNo);
            if (dto == null)
            {
                return null;
            }
            else
            {
                return new GetWorkOrderModel
                {
                    ReferenceWorkOrderNo = dto.ReferenceWorkOrderNo,
                    StockCode = dto.StockCode,
                    StockName = dto.StockName,
                    OrderGroup = dto.OrderGroup,
                    MachineNo = dto.MachineNo,
                    MachineCode = dto.MachineCode,
                    MachineName = dto.MachineName,
                    WorkOrderNo = dto.WorkOrderNo,
                    Amount = dto.Amount,
                    AlkUserName = dto.AlkUserName,
                    AlkNormalizedUserName = dto.AlkNormalizedUserName,
                    ColorCode = dto.ColorCode,
                    ColorName = dto.ColorName,
                    Deadline = dto.Deadline,
                    ProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                    ReceivedAmount = _receiveDal.GetTotalByOutsourceWorkOrderId(dto.Id)
                };
            }
            
        }

        public List<GetWorkOrderModel> GetWorkOrdersBySituationId(int id)
        {
            var DTOs = _outsourceWorkOrderDal.GetWorkOdersBySituationId(id);
            var models = new List<GetWorkOrderModel>();
            foreach(var dto in DTOs)
            {
                models.Add(new GetWorkOrderModel
                {
                    ReferenceWorkOrderNo = dto.ReferenceWorkOrderNo,
                    StockCode = dto.StockCode,
                    StockName = dto.StockName,
                    OrderGroup = dto.OrderGroup,
                    MachineNo = dto.MachineNo,
                    MachineCode = dto.MachineCode,
                    MachineName = dto.MachineName,
                    WorkOrderNo = dto.WorkOrderNo,
                    Amount = dto.Amount,
                    AlkUserName = dto.AlkUserName,
                    AlkNormalizedUserName = dto.AlkNormalizedUserName,
                    ColorCode = dto.ColorCode,
                    ColorName = dto.ColorName,
                    Deadline = dto.Deadline,
                    ProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(dto.Id),
                    ReceivedAmount = _receiveDal.GetTotalByOutsourceWorkOrderId(dto.Id)
            });
            }
            return models;
        }

        public void MakeCompleted(int outsourceWorkOrderId, string currentUser)
        {
            var outsourceWorkOrder = _outsourceWorkOrderDal.Get(o => o.Id == outsourceWorkOrderId);
            outsourceWorkOrder.SituationId = (int)SituationEnum.Completed;
            outsourceWorkOrder.UpdatedBy = currentUser;
            outsourceWorkOrder.UpdatedOn = DateTime.Now;
            _outsourceWorkOrderDal.Update(outsourceWorkOrder);
        }

        public ResultViewModel<OutsourceWorkOrder> TryToMakeFinish(string workOrderNo, string currentUser)
        {
            var outsourceWorkOrder = _outsourceWorkOrderDal.Get(o => o.WorkOrderNo == workOrderNo);
            if(outsourceWorkOrder != null)
            {
                if(outsourceWorkOrder.SituationId == (int)SituationEnum.Completed)
                {
                    if (!_receiveDal.AnyNotApprovedByOutsourceWorkId(outsourceWorkOrder.Id))
                    {
                        decimal totalProducedAmount = _trackingDal.GetTotalByOutsourceWorkOrderId(outsourceWorkOrder.Id);
                        decimal totalReceivedAmount = _receiveDal.GetTotalByOutsourceWorkOrderId(outsourceWorkOrder.Id);
                        if (totalProducedAmount == totalReceivedAmount)
                        {
                            outsourceWorkOrder.SituationId = (int)SituationEnum.Finish;
                            outsourceWorkOrder.ReceivedDate = DateTime.Now;
                            outsourceWorkOrder.UpdatedBy = currentUser;
                            outsourceWorkOrder.UpdatedOn = DateTime.Now;
                            _outsourceWorkOrderDal.Update(outsourceWorkOrder);
                        }
                    }
                }
                return new ResultViewModel<OutsourceWorkOrder> { Success = true };
            }
            return new ResultViewModel<OutsourceWorkOrder> { Success = false, Message = "İş emri numarası bulunamadı." };
        }

        public GetWorkOrderDetailsModel GetDetailsByWorkOrderNo(string workOrderNo)
        {
            var outsourceWorkOrderId = _outsourceWorkOrderDal.Get(owo => owo.WorkOrderNo == workOrderNo).Id;
            return new GetWorkOrderDetailsModel
            {
                Receives = _receiveDal.GetReceivesWithUsersByOutsourceWorkOrderId(outsourceWorkOrderId),//   GetList(r => !r.IsDeleted && r.OutsourceWorkOrderId == outsourceWorkOrderId),
                Trackings = _trackingDal.GetList(t => !t.IsDeleted && t.OutsourceWorkOrderId == outsourceWorkOrderId)
            };
        }
    }
    
}
