using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.Core.DataAccess.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    public class EfAlkWorkOrderDal : EfEntityRepositoryBase<AlkWorkOrder, ApplicationIdenityDbContext>, IAlkWorkOrderDal
    {
        private readonly ApplicationIdenityDbContext _context;
        public EfAlkWorkOrderDal() { }
        public EfAlkWorkOrderDal(ApplicationIdenityDbContext context)
        {
            _context = context;
        }
        public int GetLastId()
        {
            return ( from o in _context.AlkWorkOrders
                     where !o.IsDeleted
                     orderby o.Id
                     select o ).Last().Id;
        }
    }
}
