using OutsourcerTracking.Labels.Core.DataAccess.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    public class EfUsersRolesDal : EfEntityRepositoryBase<UsersRoles, ApplicationIdenityDbContext>, IUsersRolesDal
    {
    }
}
