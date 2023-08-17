using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models;
using OutsourcerTracking.Models.OutsourceHomeModels;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class TrackingManager : ITrackingService
    {
        private readonly ITrackingDal _trackingDal;
        private readonly IReceiveDal _receivedDal;
        public TrackingManager(ITrackingDal trackingDal, IReceiveDal receivedal)
        {
            _trackingDal = trackingDal;
            _receivedDal = receivedal;
        }

        public ResultViewModel<Tracking> AddTrackingFromOutsourceHome(OutsourceHomeAddTrackingViewModel addVM, string currentUser)
        {
            if(addVM.Amount <= 0 || addVM.Weight_Kg <= 0)
            {
                return new ResultViewModel<Tracking> { Success = false, Message = "Üretilen Miktar veya Ağırlık Sıfır veya Eksi Olamaz." };
            }
            SealByOutsourceWorkOrderId(addVM.OutsourceWorkOrderId);
            _trackingDal.Add(new Tracking
            {
                OutsourceWorkOrderId = addVM.OutsourceWorkOrderId,
                Date = addVM.Date > DateTime.Now.AddMinutes(-5) ? addVM.Date : DateTime.Now,
                Amount = addVM.Amount,
                Weight_Kg = addVM.Weight_Kg,
                CreatedBy = currentUser,
                CreatedOn = DateTime.Now,
            });
            return new ResultViewModel<Tracking> { Success = true, Message = "" };
        }
        public ResultViewModel<Tracking> EditTrackingFromOutsourceHome(OutsourceHomeEditTrackingViewModel editVM, string currentUser)
        {
            var track = _trackingDal.Get(t => t.Id == editVM.Id);
            decimal totalReceived = _receivedDal.GetTotalByOutsourceWorkOrderId(editVM.OutsourceWorkOrderId);
            decimal totalProduced = _trackingDal.GetTotalByOutsourceWorkOrderId(editVM.OutsourceWorkOrderId);
            if (editVM.Amount <= 0 || editVM.Weight_Kg <= 0)
            {
                return new ResultViewModel<Tracking> { Success = false, Message = "Üretilen Miktar veya Ağırlık Sıfır veya Eksi Olamaz." };
            }
            else if (totalReceived > totalProduced - track.Amount + editVM.Amount)
            {
                return new ResultViewModel<Tracking> { Success = false, Message = "Toplam Teslim Edilen Adetin Altına düşülemez." };
            }
            track.Amount = editVM.Amount;
            track.Weight_Kg = editVM.Weight_Kg;
            track.UpdatedOn = DateTime.Now;
            track.UpdatedBy = currentUser;
            _trackingDal.Update(track);
            return new ResultViewModel<Tracking> { Success = true, Message = "" };
        }
        public List<Tracking> GetListByOutsourceWorkOrderId(int id)
        {
            SealByDate(id);
            return _trackingDal.GetList(t => !t.IsDeleted && t.OutsourceWorkOrderId == id);
        }
        public void SealByOutsourceWorkOrderId(int id)
        {
            var willBeSealedList = _trackingDal.GetList(t => !t.IsDeleted && t.OutsourceWorkOrderId == id && !t.IsSealed);
            willBeSealedList.ForEach(t =>
            {
                t.IsSealed = true;
                _trackingDal.Update(t);
            });
        }
        public void SealByDate()
        {
            var willBeSealedList = _trackingDal.GetList(t => !t.IsDeleted && t.Date < DateTime.Now.AddMinutes(-30) && !t.IsSealed);
            willBeSealedList.ForEach(t =>
            {
                t.IsSealed = true;
                _trackingDal.Update(t);
            });
        }
        public void SealByDate(int outsourceWorkOrderId)
        {
            var willBeSealedList = _trackingDal.GetList(t => !t.IsDeleted && t.Date < DateTime.Now.AddMinutes(-30) && !t.IsSealed && t.OutsourceWorkOrderId == outsourceWorkOrderId);
            willBeSealedList.ForEach(t =>
            {
                t.IsSealed = true;
                _trackingDal.Update(t);
            });
        }
        public void CancelSealedByDate(int outsourceWorkOrderId)
        {
            var willCancelSealed = _trackingDal.GetToCancelSealedByOutsourceWorkOrderId(outsourceWorkOrderId);
            if(willCancelSealed != null)
            {
                willCancelSealed.IsSealed = false;
                _trackingDal.Update(willCancelSealed);
            }
        }
        public bool AnyNotSealedByOutsourceWorkOrderId(int id)
        {
            SealByDate(id);
            return _trackingDal.AnyNotSealedByOutsourceWorkOrderId(id);
        }
        public void Delete(int id, string currentUserName)
        {
            var tracking = _trackingDal.Get(u => u.Id == id);
            tracking.IsDeleted = true;
            tracking.UpdatedOn = DateTime.Now;
            tracking.UpdatedBy = currentUserName;
            _trackingDal.Update(tracking);
            CancelSealedByDate(tracking.OutsourceWorkOrderId);
        }
    }
}
