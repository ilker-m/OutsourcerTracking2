using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models;
using OutsourcerTracking.Models.OutsourceHomeModels;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface ITrackingService
    {
        ResultViewModel<Tracking> AddTrackingFromOutsourceHome(OutsourceHomeAddTrackingViewModel addVM, string currentUser);
        List<Tracking> GetListByOutsourceWorkOrderId(int id);
        void SealByOutsourceWorkOrderId(int id);
        void SealByDate();
        void SealByDate(int outsourceWorkOrderId);
        void CancelSealedByDate(int outsourceWorkOrderId);
        bool AnyNotSealedByOutsourceWorkOrderId(int id);
        ResultViewModel<Tracking> EditTrackingFromOutsourceHome(OutsourceHomeEditTrackingViewModel editVM, string currentUser);
        void Delete(int id, string currentUserName);
    }
}
