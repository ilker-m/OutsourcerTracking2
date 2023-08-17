using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Abstract
{
    public interface IRoleService
    {
        List<Role> GetAllEmployeeRoles();
        List<Role> GetAllOutsourceRoles();
    }
}
