using OutsourcerTracking.Labels.Core.DataAccess;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Abstract
{
    public interface IOutsourcesOutsourceUsersDal : IEntityRepository<OutsourcesOutsourceUsers>
    {
        void DeleteManuel(OutsourcesOutsourceUsers entity);
    }
}
