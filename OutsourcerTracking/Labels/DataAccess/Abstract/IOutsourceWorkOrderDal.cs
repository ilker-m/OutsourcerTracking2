using OutsourcerTracking.Labels.Business.DTOs;
using OutsourcerTracking.Labels.Core.DataAccess;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.APIModels;
using OutsourcerTracking.Models.EmployeeHomeModels;
using OutsourcerTracking.Models.OutsourceHomeModels;

namespace OutsourcerTracking.Labels.DataAccess.Abstract
{
    public interface IOutsourceWorkOrderDal : IEntityRepository<OutsourceWorkOrder>
    {
        List<WorkOrderTableDTO> GetForOutsourceTableBySituationId(int id);
        List<WorkOrderTableDTO> GetForEmployeeTable();
        GetToAddReceiveDTO GetToAddReciveById(int id);
        GetToEditReceiveDTO GetToEditReciveById(int id);
        List<WorkOrderTableDTO> GetForOutsourceTableByUserId(int id);
        List<WorkOrderTableDTO> GetForTableByOutsourceId(int id);
        GetToAddTrackingDTO GetToAddTrakingById(int id);
        GetToEditTrackingDTO GetToEditTrackingById(int id);
        WorkOrderTableDTO GetForEmployeeTableById(int id);
        List<OutsourceWorkOrderIntegrationDTO> GetChanges();
        GetWorkOrderDTO? GetWorkOderByWorkOrderNo(string workOrderNo);
        List<GetWorkOrderDTO> GetWorkOdersBySituationId(int id);
    }
}
