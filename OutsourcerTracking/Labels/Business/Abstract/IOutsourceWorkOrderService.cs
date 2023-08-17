using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models;
using OutsourcerTracking.Models.APIModels;
using OutsourcerTracking.Models.EmployeeHomeModels;
using OutsourcerTracking.Models.OutsourceHomeModels;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IOutsourceWorkOrderService
    {
        List<EmployeeHomeViewModel> GetBySituationIdForEmployeeTable(int id);
        List<EmployeeHomeViewModel> GetForEmployeeTable();
        EmployeeHomeViewModel GetForEmployeeTableById(int id);
        EmployeeHomeAddReceiveViewModel GetToAddReciveById(int id, string currentUser);
        EmployeeHomeEditReceiveViewModel GetToEditReciveById(int id);
        List<OutsourceHomeViewModel> GetForOutsourceTableByUserName(string name);
        List<OutsourceHomeViewModel> GetForOutsourceTableByOutsourceId(int id);
        OutsourceHomeAddTrackingViewModel GetToAddTrackingById(int id);
        OutsourceHomeEditTrackingViewModel GetToEditTrackingById(int id);
        void SetSituation(int id);
        List<OutsourceWorkOrder> GetAll();
        OutsourceWorkOrder GetById(int id);
        void Add(OutsourceWorkOrder outsourceWorkOrder, string currentUser);
        void Edit(OutsourceWorkOrder outsourceWorkOrder, string currentUser);
        void Delete(int id, string currentUser);
        OutsourceWorkOrder GetByWorkOrderNo(string workOrder);
        List<OutsourceWorkOrderIntegrationModel> GetChanges();
        ResultViewModel<AddEditWorkOrderModel> AddWorkOrder(AddEditWorkOrderModel addWorkOrderModel, string currentUser);
        ResultViewModel<AddEditWorkOrderModel> EditWorkOrder(AddEditWorkOrderModel addWorkOrderModel, OutsourceWorkOrder outsourceWorkOrder, string currentUser);
        GetWorkOrderModel? GetWorkOrderNoByWorkOrderNo(string workOrderNo);
        List<GetWorkOrderModel> GetWorkOrdersBySituationId(int id);
        void MakeCompleted(int outsourceWorkOrderId, string currentUser);
        ResultViewModel<OutsourceWorkOrder> TryToMakeFinish(string workOrderNo, string currentUser);
        GetWorkOrderDetailsModel GetDetailsByWorkOrderNo(string workOrderNo);
    }
}
