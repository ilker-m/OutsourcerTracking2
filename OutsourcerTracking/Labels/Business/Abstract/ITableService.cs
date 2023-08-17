using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface ITableService
    {
        List<Table> GetAll();
        bool CheckChanges();
    }
}
