using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class UsersRolesManager : IUsersRolesService
    {
        private readonly IUsersRolesDal _dal;
        public UsersRolesManager(IUsersRolesDal dal)
        {
            _dal = dal;
        }
        public void Add(UsersRoles usersRoles)
        {
            _dal.Add(usersRoles);
        }
    }
}
