using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class OperationManager : IOperationService
    {
        private readonly IOperationDal _dal;
        public OperationManager(IOperationDal dal)
        {
            _dal = dal;
        }
        public Operation GetByNo(string opNo)
        {
            return _dal.Get(op => op.No == opNo);
        }
    }
}
