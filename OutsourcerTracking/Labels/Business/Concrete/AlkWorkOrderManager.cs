using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class AlkWorkOrderManager : IAlkWorkOrderService
    {
        private IAlkWorkOrderDal _dal;
        public AlkWorkOrderManager(IAlkWorkOrderDal dal)
        {
            _dal = dal;
        }

        public int Add(AlkWorkOrder alkWorkOrder, string currentUser)
        {
            alkWorkOrder.CreatedBy = currentUser;
            alkWorkOrder.CreatedOn = DateTime.Now;
            _dal.Add(alkWorkOrder);
            return _dal.GetLastId();
        }

        public void Delete(int id, string currentUser)
        {
            var alkWorkOrder = _dal.Get(o => o.Id == id);
            alkWorkOrder.UpdatedBy = currentUser;
            alkWorkOrder.UpdatedOn = DateTime.Now;
            alkWorkOrder.IsDeleted = true;
            _dal.Update(alkWorkOrder);
        }

        public void Edit(AlkWorkOrder alkWorkOrder, string currentUser)
        {
            var oldAlkWorkOrder = _dal.Get(o => o.Id == alkWorkOrder.Id);
            alkWorkOrder.CreatedBy = oldAlkWorkOrder.CreatedBy;
            alkWorkOrder.CreatedOn = oldAlkWorkOrder.CreatedOn;
            alkWorkOrder.UpdatedBy = currentUser;
            alkWorkOrder.UpdatedOn = DateTime.Now;
            _dal.Update(alkWorkOrder);
        }

        public List<AlkWorkOrder> GetAll()
        {
            return _dal.GetList(awo => !awo.IsDeleted);
        }

        public AlkWorkOrder GetById(int id)
        {
            return _dal.Get(awo => awo.Id == id);
        }

        public AlkWorkOrder GetByReferenceWorkOrderNo(string referenceWorkOrder)
        {
            return _dal.Get(awo => awo.ReferenceWorkOrderNo == referenceWorkOrder.Trim());
        }
    }
}
