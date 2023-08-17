using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }
        public List<Role> GetAllEmployeeRoles()
        {
            return _roleDal.GetList(r => r.Id != 3 /*&& !r.IsDeleted*/);
        }
        public List<Role> GetAllOutsourceRoles()
        {
            return _roleDal.GetList(r => r.Id == 3 /*&& !r.IsDeleted*/);
        }
    }
}
