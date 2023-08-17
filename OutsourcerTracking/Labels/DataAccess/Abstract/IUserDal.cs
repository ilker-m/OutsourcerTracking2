using OutsourcerTracking.Labels.Core.DataAccess;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        public int GetLastUserId();
    }
}
