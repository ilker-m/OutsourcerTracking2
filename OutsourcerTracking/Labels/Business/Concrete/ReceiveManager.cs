using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models;
using OutsourcerTracking.Models.EmployeeHomeModels;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class ReceiveManager : IReceiveService
    {
        private readonly IReceiveDal _receiveDal;
        private readonly ITrackingDal _trackingDal;
        private readonly ITrackingService _trackingService;
        public ReceiveManager(IReceiveDal receiveDal, ITrackingDal trackingDal, ITrackingService trackingService)
        {
            _receiveDal = receiveDal;
            _trackingDal = trackingDal;
            _trackingService = trackingService;
        }
        public ResultViewModel<Receive> AddReceiveFromEmployeeHome(EmployeeHomeAddReceiveViewModel addVM, string currentUser)
        {
            decimal totalProduced = _trackingDal.GetTotalByOutsourceWorkOrderId(addVM.OutsourceWorkOrderId);
            decimal totalReceived = _receiveDal.GetTotalByOutsourceWorkOrderId(addVM.OutsourceWorkOrderId);
            decimal willTotalReceived = totalReceived + addVM.Amount;
            if (totalProduced < willTotalReceived)
            {
                return new ResultViewModel<Receive> { Success = false, Message = "Toplam Üretilen Adet, Toplam Teslim Alınan Adeti Geçemez." };
            }
            else if(addVM.Amount <= 0)
            {
                return new ResultViewModel<Receive> { Success = false, Message = "Teslim Alınan Adet Sıfır veya Eksi Olamaz." };
            }
            SealByOutsourceWorkOrderId(addVM.OutsourceWorkOrderId);
            if(willTotalReceived == totalProduced)
            {
                _trackingService.SealByOutsourceWorkOrderId(addVM.OutsourceWorkOrderId);
            }
            _receiveDal.Add(new Receive
            {
                OutsourceWorkOrderId = addVM.OutsourceWorkOrderId,
                EmployeeUserId = addVM.EmployeeUserId,
                Date = addVM.Date < DateTime.Now.AddMinutes(-5) ? addVM.Date : DateTime.Now,
                Amount = addVM.Amount,
                CreatedBy = currentUser,
                CreatedOn = DateTime.Now,
            });
            return new ResultViewModel<Receive> { Success = true, Message = "" };
        }
        public ResultViewModel<Receive> EditReceiveFromEmployeeHome(EmployeeHomeEditReceiveViewModel editVM, string currentUser)
        {
            var receive = _receiveDal.Get(r => r.Id == editVM.Id);
            decimal totalProduced = _trackingDal.GetTotalByOutsourceWorkOrderId(editVM.OutsourceWorkOrderId);
            decimal totalReceived = _receiveDal.GetTotalByOutsourceWorkOrderId(editVM.OutsourceWorkOrderId) - receive.Amount;
            decimal willTotalReceived = totalReceived + editVM.Amount;
            if (totalProduced < willTotalReceived)
            {
                return new ResultViewModel<Receive> { Success = false, Message = "Toplam Teslim Alınan Adet, Toplam Üretilen Adeti Geçemez." };
            }
            else if (editVM.Amount <= 0)
            {
                return new ResultViewModel<Receive> { Success = false, Message = "Teslim Alınan Adet Sıfır veya Eksi Olamaz." };
            }
            if (willTotalReceived == totalProduced)
            {
                _trackingService.SealByOutsourceWorkOrderId(editVM.OutsourceWorkOrderId);
            }
            else
            {
                _trackingService.CancelSealedByDate(editVM.OutsourceWorkOrderId);
            }
            receive.EmployeeUserId = editVM.EmployeeUserId;
            receive.Amount = editVM.Amount;
            receive.UpdatedOn = DateTime.Now;
            receive.UpdatedBy = currentUser;
            _receiveDal.Update(receive);
            return new ResultViewModel<Receive> { Success = true, Message = "" };
        }
        public List<Receive> GetAllByOutsourceWorkOrderId(int id)
        {
            SealByDate(id);
            return _receiveDal.GetList(r => !r.IsDeleted && r.OutsourceWorkOrderId == id);
        }
        public void SealByOutsourceWorkOrderId(int id)
        {
            var willBeSealedList = _receiveDal.GetList(r => !r.IsDeleted && r.OutsourceWorkOrderId == id && !r.IsSealed);
            willBeSealedList.ForEach(r =>
            {
                r.IsSealed = true;
                _receiveDal.Update(r);
            });
        }
        public void SealByDate()
        {
            var willBeSealedList = _receiveDal.GetList(r => !r.IsDeleted && r.Date < DateTime.Now.AddMinutes(-30) && !r.IsSealed);
            willBeSealedList.ForEach(r =>
            {
                r.IsSealed = true;
                _receiveDal.Update(r);
            });
        }
        public void SealByDate(int outsourceWorkOrderId)
        {
            var willBeSealedList = _receiveDal.GetList(t => !t.IsDeleted && t.Date < DateTime.Now.AddMinutes(-30) && !t.IsSealed && t.OutsourceWorkOrderId == outsourceWorkOrderId);
            willBeSealedList.ForEach(t =>
            {
                t.IsSealed = true;
                _receiveDal.Update(t);
            });
        }
        public void CancelSealedByDate(int outsourceWorkOrderId)
        {
            var willCancelSealed = _receiveDal.GetToCancelSealedByOutsourceWorkOrderId(outsourceWorkOrderId);
            if(willCancelSealed != null)
            {
                willCancelSealed.IsSealed = false;
                _receiveDal.Update(willCancelSealed);
            }
        }
        public bool AnyNotSealedByOutsourceWorkOrderId(int id)
        {
            SealByDate(id);
            return _receiveDal.AnyNotSealedByOutsourceWorkOrderId(id);
        }
        public void Delete(int id, string currentUserName)
        {
            var receive = _receiveDal.Get(u => u.Id == id);
            receive.IsDeleted = true;
            receive.UpdatedOn = DateTime.Now;
            receive.UpdatedBy = currentUserName;
            _receiveDal.Update(receive);
            CancelSealedByDate(receive.OutsourceWorkOrderId);
            _trackingService.CancelSealedByDate(receive.OutsourceWorkOrderId);
        }

        public DateTime? GetLastDateByOutsourceWorkOrderId(int id)
        {
            return _receiveDal.GetOrderedLastDateByOutsourceWorkOrderId(id)?.Date;
        }

        public void ApproveReceivesByIds(int[] ids, string currentUser)
        {
            var receives = _receiveDal.GetList(r => ids.Contains(r.Id));
            receives.ForEach(r => { 
                r.ApprovedDate = DateTime.Now; 
                r.UpdatedOn = DateTime.Now;
                r.UpdatedBy = currentUser;
                _receiveDal.Update(r);
            });
        }
    }
}
