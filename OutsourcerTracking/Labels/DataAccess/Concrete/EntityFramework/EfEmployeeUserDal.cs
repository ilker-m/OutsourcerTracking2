using OutsourcerTracking.Labels.Core.DataAccess.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.EmployeeUserModels;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeUserDal : EfEntityRepositoryBase<EmployeeUser, ApplicationIdenityDbContext>, IEmployeeUserDal
    {
        private ApplicationIdenityDbContext _context;
        public EfEmployeeUserDal() { }
        public EfEmployeeUserDal(ApplicationIdenityDbContext context)
        {
            _context = context;
        }
        public List<EmployeeUserViewModel> GetAllFullRelational()
        {
            return ( from eu in _context.EmployeeUsers
                     join u in _context.Users on eu.Id equals u.Id
                     join t in _context.Titles on eu.TitleId equals t.Id
                     join d in _context.Departments on eu.DepartmentId equals d.Id
                     join ur in _context.UsersRoles on eu.Id equals ur.UserId
                     join r in _context.Roles on ur.RoleId equals r.Id
                     where !u.IsDeleted
                     select new EmployeeUserViewModel
                     {
                         Id = eu.Id,
                         FirstName = u.FirstName,
                         LastName = u.LastName,
                         Email = u.Email,
                         Phone = u.PhoneNumber,
                         RoleName = r.Name,
                         DepartmentName = d.Name,
                         TitleName = t.Name
                     } ).ToList();
        }

        public EmployeeUser GetByIdWithUser(int id)
        {
            return ( from eu in _context.EmployeeUsers
                     join u in _context.Users on eu.Id equals u.Id
                     join t in _context.Titles on eu.TitleId equals t.Id
                     join d in _context.Departments on eu.DepartmentId equals d.Id
                     where eu.Id == id && !u.IsDeleted
                     select new EmployeeUser
                     {
                         Id = eu.Id,
                         User = u,
                         TitleId = eu.TitleId,
                         Title = t,
                         DepartmentId = eu.DepartmentId,
                         Department = d
                     } ).First();
        }

        public List<User> GetTransporterNames()
        {
            return ( from eu in _context.EmployeeUsers
                     join u in _context.Users on eu.Id equals u.Id
                     join t in _context.Titles on eu.TitleId equals t.Id
                     where !u.IsDeleted && eu.TitleId == 3
                     select new User
                     {
                         Id = u.Id,
                         FirstName = u.FirstName,
                         LastName = u.LastName
                     }).ToList();
        }
    }
}
