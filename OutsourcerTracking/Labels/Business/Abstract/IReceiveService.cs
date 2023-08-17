using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models;
using OutsourcerTracking.Models.EmployeeHomeModels;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IReceiveService
    {
        List<Receive> GetAllByOutsourceWorkOrderId(int id);
        ResultViewModel<Receive> AddReceiveFromEmployeeHome(EmployeeHomeAddReceiveViewModel addVM, string currentUser);
        void SealByOutsourceWorkOrderId(int id);
        void SealByDate();
        void SealByDate(int outsourceWorkOrderId);
        void CancelSealedByDate(int outsourceWorkOrderId);
        bool AnyNotSealedByOutsourceWorkOrderId(int id);
        ResultViewModel<Receive> EditReceiveFromEmployeeHome(EmployeeHomeEditReceiveViewModel editVM, string currentUser);
        void Delete(int id, string currentUser);
        DateTime? GetLastDateByOutsourceWorkOrderId(int id);
        void ApproveReceivesByIds(int[] ids, string currentUser);
    }
}
