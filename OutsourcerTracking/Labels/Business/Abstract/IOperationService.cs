using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IOperationService
    {
        Operation GetByNo(string opNo);
    }
}
