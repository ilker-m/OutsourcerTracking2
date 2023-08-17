using OutsourcerTracking.Labels.Core.DataAccess.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ApplicationIdenityDbContext>, IUserDal
    {
        private readonly ApplicationIdenityDbContext _context;
        public EfUserDal() { }
        public EfUserDal(ApplicationIdenityDbContext context)
        {
            _context = context;
        }
        public int GetLastUserId()
        {
            return ( from u in _context.Users
                     where !u.IsDeleted
                     orderby u.Id
                     select u ).Last().Id;
        }

    }
}
