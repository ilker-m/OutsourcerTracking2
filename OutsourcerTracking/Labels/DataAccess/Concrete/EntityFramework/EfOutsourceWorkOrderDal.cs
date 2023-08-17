using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.Business.DTOs;
using OutsourcerTracking.Labels.Core.DataAccess.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Labels.DataAccess.Enums;
using OutsourcerTracking.Models.APIModels;
using OutsourcerTracking.Models.EmployeeHomeModels;
using OutsourcerTracking.Models.OutsourceHomeModels;
using OutsourceTrackingWorkerService.Models.ModelEnums;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    public class EfOutsourceWorkOrderDal : EfEntityRepositoryBase<OutsourceWorkOrder, ApplicationIdenityDbContext>, IOutsourceWorkOrderDal
    {
        private readonly ApplicationIdenityDbContext _context;
        public EfOutsourceWorkOrderDal() { }
        public EfOutsourceWorkOrderDal(ApplicationIdenityDbContext context)
        {
            _context = context;
        }
        public List<WorkOrderTableDTO> GetForOutsourceTableBySituationId(int id)
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join awo in _context.AlkWorkOrders on owo.AlkWorkOrderId equals awo.Id
                     join o in _context.Outsources on owo.OutsourceId equals o.Id
                     join s in _context.Situations on owo.SituationId equals s.Id
                     where !owo.IsDeleted && !o.IsDeleted && !awo.IsDeleted && owo.SituationId == id
                     select new WorkOrderTableDTO
                     {
                         Id = owo.Id,
                         AlkWorkOrderId = owo.AlkWorkOrderId,
                         ReferenceWorkOrder = awo.ReferenceWorkOrderNo,
                         OrderGroup = awo.OrderGroup,
                         StockCode = awo.StockCode,
                         OutsourceId = o.Id,
                         OutsourceName = o.MachineName,
                         SituationId = s.Id,
                         SituationName = s.Name,
                         ColorCode = owo.ColorCode,
                         ColorName = owo.ColorName,
                         WorkOrderNo = owo.WorkOrderNo,
                         Deadline = owo.Deadline,
                         Amount = owo.Amount,
                     } ).ToList();
        }

        public List<WorkOrderTableDTO> GetForEmployeeTable()
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join awo in _context.AlkWorkOrders on owo.AlkWorkOrderId equals awo.Id
                     join o in _context.Outsources on owo.OutsourceId equals o.Id
                     join s in _context.Situations on owo.SituationId equals s.Id
                     where !owo.IsDeleted && !o.IsDeleted && !awo.IsDeleted && owo.SituationId != (int)SituationEnum.Finish
                     select new WorkOrderTableDTO
                     {
                         Id = owo.Id,
                         AlkWorkOrderId = owo.AlkWorkOrderId,
                         ReferenceWorkOrder = awo.ReferenceWorkOrderNo,
                         OrderGroup = awo.OrderGroup,
                         StockCode = awo.StockCode,
                         OutsourceId = o.Id,
                         OutsourceName = o.MachineName,
                         SituationId = s.Id,
                         SituationName = s.Name,
                         ColorCode = owo.ColorCode,
                         ColorName = owo.ColorName,
                         WorkOrderNo = owo.WorkOrderNo,
                         Deadline = owo.Deadline,
                         Amount = owo.Amount,
                     } ).ToList();
        }
        public WorkOrderTableDTO GetForEmployeeTableById(int id)
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join awo in _context.AlkWorkOrders on owo.AlkWorkOrderId equals awo.Id
                     join o in _context.Outsources on owo.OutsourceId equals o.Id
                     join s in _context.Situations on owo.SituationId equals s.Id
                     where owo.Id == id
                     select new WorkOrderTableDTO
                     {
                         Id = owo.Id,
                         AlkWorkOrderId = owo.AlkWorkOrderId,
                         ReferenceWorkOrder = awo.ReferenceWorkOrderNo,
                         OrderGroup = awo.OrderGroup,
                         StockCode = awo.StockCode,
                         OutsourceId = o.Id,
                         OutsourceName = o.MachineName,
                         SituationId = s.Id,
                         SituationName = s.Name,
                         ColorCode = owo.ColorCode,
                         ColorName = owo.ColorName,
                         WorkOrderNo = owo.WorkOrderNo,
                         Deadline = owo.Deadline,
                         Amount = owo.Amount,
                     } ).First();
        }
        public GetToAddReceiveDTO GetToAddReciveById(int id)
        {
            return (from owo in _context.OutsourceWorkOrders
                    join owa in _context.AlkWorkOrders on owo.AlkWorkOrderId equals owa.Id
                    where owo.Id == id
                    select new GetToAddReceiveDTO
                    {
                        OutsourceWorkOrderId = owo.Id,
                        ReferenceWorkOrder = owa.ReferenceWorkOrderNo,
                        WorkOrder = owo.WorkOrderNo,
                        OrderGroup = owa.OrderGroup,
                        StockCode = owa.StockCode,
                        WillProduceTotalAmount = owo.Amount
                    }).First();
        }
        public GetToEditReceiveDTO GetToEditReciveById(int id)
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join owa in _context.AlkWorkOrders on owo.AlkWorkOrderId equals owa.Id
                     join r in _context.Recieves on owo.Id equals r.OutsourceWorkOrderId
                     where owo.Id == id && !r.IsDeleted && !r.IsSealed
                     select new GetToEditReceiveDTO
                     {
                         Id = r.Id,
                         OutsourceWorkOrderId = owo.Id,
                         ReferenceWorkOrder = owa.ReferenceWorkOrderNo,
                         WorkOrder = owo.WorkOrderNo,
                         OrderGroup = owa.OrderGroup,
                         StockCode = owa.StockCode,
                         EmployeeUserId = r.EmployeeUserId,
                         WillProduceTotalAmount = owo.Amount,
                         Amount = r.Amount,
                         AmountAgain = r.Amount,
                         Date = r.Date
                     } ).First();
        }
        public List<WorkOrderTableDTO> GetForOutsourceTableByUserId(int id)
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join awo in _context.AlkWorkOrders on owo.AlkWorkOrderId equals awo.Id
                     join o in _context.Outsources on owo.OutsourceId equals o.Id
                     join oou in _context.OutsourcesOutsourceUsers on o.Id equals oou.OutsourceId
                     join s in _context.Situations on owo.SituationId equals s.Id
                     where !owo.IsDeleted && !awo.IsDeleted && !o.IsDeleted && oou.OutsourceUserId == id && s.Id != (int) SituationEnum.Finish
                     select new WorkOrderTableDTO
                     {
                         Id = owo.Id,
                         AlkWorkOrderId = awo.Id,
                         ReferenceWorkOrder = awo.ReferenceWorkOrderNo,
                         OrderGroup = awo.OrderGroup,
                         StockCode = awo.StockCode,
                         OutsourceId = owo.OutsourceId,
                         OutsourceName = o.MachineName,
                         SituationId = owo.SituationId,
                         SituationName = s.Name,
                         ColorCode = owo.ColorCode,
                         ColorName = owo.ColorName,
                         WorkOrderNo = owo.WorkOrderNo,
                         Deadline = owo.Deadline,
                         Amount = owo.Amount
                     } ).ToList();
        }

        public List<WorkOrderTableDTO> GetForTableByOutsourceId(int id)
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join awo in _context.AlkWorkOrders on owo.AlkWorkOrderId equals awo.Id
                     join o in _context.Outsources on owo.OutsourceId equals o.Id
                     join s in _context.Situations on owo.SituationId equals s.Id
                     where !owo.IsDeleted && !awo.IsDeleted && owo.OutsourceId == id && s.Id != (int)SituationEnum.Finish
                     select new WorkOrderTableDTO
                     {
                         Id = owo.Id,
                         AlkWorkOrderId = owo.AlkWorkOrderId,
                         ReferenceWorkOrder = awo.ReferenceWorkOrderNo,
                         OrderGroup = awo.OrderGroup,
                         StockCode = awo.StockCode,
                         OutsourceId = o.Id,
                         OutsourceName = o.MachineName,
                         SituationId = s.Id,
                         SituationName = s.Name,
                         ColorCode = owo.ColorCode,
                         ColorName = owo.ColorName,
                         WorkOrderNo = owo.WorkOrderNo,
                         Deadline = owo.Deadline,
                         Amount = owo.Amount,
                     } ).ToList();
        }
        public GetToAddTrackingDTO GetToAddTrakingById(int id)
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join awo in _context.AlkWorkOrders on owo.AlkWorkOrderId equals awo.Id
                     where owo.Id == id
                     select new GetToAddTrackingDTO
                     {
                         OutsourceWorkOrderId = owo.Id,
                         ReferenceWorkOrder = awo.ReferenceWorkOrderNo,
                         OrderGroup = awo.OrderGroup,
                         StockCode = awo.StockCode,
                         WorkOrder = owo.WorkOrderNo,
                         WillPoduceTotalAmount = owo.Amount
                     } ).First();
        }

        public GetToEditTrackingDTO GetToEditTrackingById(int id)
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join awo in _context.AlkWorkOrders on owo.AlkWorkOrderId equals awo.Id
                     join t in _context.Trackings on owo.Id equals t.OutsourceWorkOrderId
                     where owo.Id == id && !t.IsDeleted && !t.IsSealed
                     select new GetToEditTrackingDTO
                     {
                         Id = t.Id,
                         OutsourceWorkOrderId = owo.Id,
                         ReferenceWorkOrder = awo.ReferenceWorkOrderNo,
                         WorkOrder = owo.WorkOrderNo,
                         OrderGroup = awo.OrderGroup,
                         StockCode = awo.StockCode,
                         WillPoduceTotalAmount = owo.Amount,
                         Amount = t.Amount,
                         AmountAgain = t.Amount,
                         Weight_Kg = t.Weight_Kg,
                         Weight_KgAgain = t.Weight_Kg,
                         Date = t.Date,
                     } ).First();
        }

        public List<OutsourceWorkOrderIntegrationDTO> GetChanges()
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join awo in _context.AlkWorkOrders on owo.AlkWorkOrderId equals awo.Id
                     join o in _context.Outsources on owo.OutsourceId equals o.Id
                     join op in _context.Operations on owo.OperationId equals op.Id
                     where owo.IntegrationStatusId != (int)IntegrationStatusEnum.Equal && !awo.IsDeleted && !owo.IsDeleted 
                     select new OutsourceWorkOrderIntegrationDTO
                     {
                         Isemrino = owo.WorkOrderNo,
                         Refisemrino = awo.ReferenceWorkOrderNo,
                         Aciklama = owo.Description,
                         Hmdepokodu = owo.RawMaterialsWarehouseCode,
                         Mamuldepokodu = owo.ProductWarehouseCode,
                         Opno = op.No,
                         Opkodu = op.Code,
                         MakinaNo = o.MachineNo,
                         Takipno = owo.Id,
                         Miktar = owo.Amount,
                         StokKodu = awo.StockCode,
                         StokAdi = awo.StockCode,
                         Istkodu = "0040",
                         Kayittarihi = owo.RecordDate,
                         Isemritarihi = owo.WorkOrderDate,
                         TeslimTarihi = owo.RecordDate,
                         IntegrationStatusId = owo.IntegrationStatusId,
                         SituationId = owo.SituationId,
                     } ).ToList();
        }

        public GetWorkOrderDTO? GetWorkOderByWorkOrderNo(string workOrderNo)
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join awo in _context.AlkWorkOrders on owo.AlkWorkOrderId equals awo.Id
                     join o in _context.Outsources on owo.OutsourceId equals o.Id
                     where owo.WorkOrderNo == workOrderNo
                     select new GetWorkOrderDTO
                     {
                         ReferenceWorkOrderNo = awo.ReferenceWorkOrderNo,
                         StockCode = awo.StockCode,
                         StockName = awo.StockName,
                         OrderGroup = awo.OrderGroup,
                         MachineNo = o.MachineNo,
                         MachineCode = o.MachineCode,
                         MachineName = o.MachineName,
                         Id = owo.Id,
                         WorkOrderNo = owo.WorkOrderNo,
                         Amount = owo.Amount,
                         AlkNormalizedUserName = owo.AlkNormalizedUserName,
                         AlkUserName = owo.AlkUserName,
                         ColorCode = owo.ColorCode,
                         ColorName = owo.ColorName,
                         Deadline = owo.Deadline,
                     } ).FirstOrDefault();  
        }

        public List<GetWorkOrderDTO> GetWorkOdersBySituationId(int id)
        {
            return ( from owo in _context.OutsourceWorkOrders
                     join awo in _context.AlkWorkOrders on owo.AlkWorkOrderId equals awo.Id
                     join o in _context.Outsources on owo.OutsourceId equals o.Id
                     where !owo.IsDeleted && owo.SituationId == id
                     select new GetWorkOrderDTO
                     {
                         ReferenceWorkOrderNo = awo.ReferenceWorkOrderNo,
                         StockCode = awo.StockCode,
                         StockName = awo.StockName,
                         OrderGroup = awo.OrderGroup,
                         MachineNo = o.MachineNo,
                         MachineCode = o.MachineCode,
                         MachineName = o.MachineName,
                         Id = owo.Id,
                         WorkOrderNo = owo.WorkOrderNo,
                         Amount = owo.Amount,
                         AlkUserName = owo.AlkUserName,
                         AlkNormalizedUserName = owo.AlkNormalizedUserName,
                         ColorCode = owo.ColorCode,
                         ColorName = owo.ColorName,
                         Deadline = owo.Deadline,
                     } ).ToList();
        }
    }
}
