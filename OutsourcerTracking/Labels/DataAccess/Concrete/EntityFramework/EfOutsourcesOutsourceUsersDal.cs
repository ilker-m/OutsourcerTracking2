using OutsourcerTracking.Labels.Core.DataAccess.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    public class EfOutsourcesOutsourceUsersDal : EfEntityRepositoryBase<OutsourcesOutsourceUsers, ApplicationIdenityDbContext>, IOutsourcesOutsourceUsersDal
    {
        private ApplicationIdenityDbContext _context;
        public EfOutsourcesOutsourceUsersDal() { }
        public EfOutsourcesOutsourceUsersDal(ApplicationIdenityDbContext context)
        {
            _context = context;
        }
        public void DeleteManuel(OutsourcesOutsourceUsers entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
