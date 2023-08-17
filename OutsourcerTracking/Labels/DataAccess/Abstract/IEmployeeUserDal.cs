using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Labels.Core.DataAccess;
using OutsourcerTracking.Models.EmployeeUserModels;

namespace OutsourcerTracking.Labels.DataAccess.Abstract
{
    public interface IEmployeeUserDal : IEntityRepository<EmployeeUser>
    {
        List<EmployeeUserViewModel> GetAllFullRelational();
        EmployeeUser GetByIdWithUser(int id);
        List<User> GetTransporterNames();
    }
}
