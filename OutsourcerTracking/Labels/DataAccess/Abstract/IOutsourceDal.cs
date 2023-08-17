using OutsourcerTracking.Labels.Core.DataAccess;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Abstract
{
    public interface IOutsourceDal : IEntityRepository<Outsource>
    {
        List<Outsource> GetAllByOutsourceUserId(int id);
        int GetLastId();
        //List<Outsource> GetWithAddress();
        //Outsource GetWithAddressById(int id);
    }
}
