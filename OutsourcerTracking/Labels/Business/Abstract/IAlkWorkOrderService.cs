using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IAlkWorkOrderService
    {
        List<AlkWorkOrder> GetAll();
        AlkWorkOrder GetById(int id);
        int Add(AlkWorkOrder alkWorkOrder, string currentUser);
        void Edit(AlkWorkOrder alkWorkOrder, string currentUser);
        void Delete(int id, string currentUser);
        AlkWorkOrder GetByReferenceWorkOrderNo(string referenceWorkOrder);
    }
}
