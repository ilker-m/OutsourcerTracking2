using OutsourcerTracking.Labels.Core.DataAccess;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.OutsouceUserModels;

namespace OutsourcerTracking.Labels.DataAccess.Abstract
{
    public interface IOutsourceUserDal : IEntityRepository<OutsourceUser>
    {
        List<OutsourceUserViewModel> GetAllFullRelation();
        OutsourceUserEditViewModel GetRelationalById(int id);
    }
}
