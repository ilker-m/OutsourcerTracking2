using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _dal;
        public DepartmentManager(IDepartmentDal dal)
        {
            _dal = dal;
        }
        public List<Department> GetAll()
        {
            return _dal.GetList(d => !d.IsDeleted);
        }
    }
}
