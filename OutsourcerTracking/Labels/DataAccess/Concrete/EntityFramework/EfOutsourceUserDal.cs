using OutsourcerTracking.Labels.Core.DataAccess.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.OutsouceUserModels;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    public class EfOutsourceUserDal : EfEntityRepositoryBase<OutsourceUser, ApplicationIdenityDbContext>, IOutsourceUserDal
    {
        private readonly ApplicationIdenityDbContext _context;
        public EfOutsourceUserDal() { }
        public EfOutsourceUserDal(ApplicationIdenityDbContext context)
        {
            _context = context;
        }
        public List<OutsourceUserViewModel> GetAllFullRelation()
        {
            var outsourceUserViewModels = ( from ou in _context.OutsourceUsers
                                            join u in _context.Users on ou.Id equals u.Id
                                            join ur in _context.UserRoles on u.Id equals ur.UserId
                                            join r in _context.Roles on ur.RoleId equals r.Id
                                            where !u.IsDeleted
                                            select new OutsourceUserViewModel
                                            {
                                                Id = ou.Id,
                                                FirstName = u.FirstName,
                                                LastName = u.LastName,
                                                Email = u.Email,
                                                Phone = u.PhoneNumber,
                                                RoleName = r.Name
                                            } ).ToList();
            outsourceUserViewModels.ForEach(o => { o.OutsourceNames = GetOutsourceNamesByUserId(o.Id); });
            return outsourceUserViewModels;
        }
        public List<string> GetOutsourceNamesByUserId(int id)
        {
            return ( from oou in _context.OutsourcesOutsourceUsers
                     join o in _context.Outsources on oou.OutsourceId equals o.Id
                     where oou.OutsourceUserId == id && !o.IsDeleted
                     select o.MachineName ).ToList();
        }

        public OutsourceUserEditViewModel GetRelationalById(int id)
        {
            var outsourceUserViewModel = ( from ou in _context.OutsourceUsers
                                            join u in _context.Users on ou.Id equals u.Id
                                            join ur in _context.UserRoles on u.Id equals ur.UserId
                                            join r in _context.Roles on ur.RoleId equals r.Id
                                            where !u.IsDeleted && u.Id == id
                                            select new OutsourceUserEditViewModel
                                            {
                                                Id = ou.Id,
                                                FirstName = u.FirstName,
                                                LastName = u.LastName,
                                                Email = u.Email,
                                                Phone = u.PhoneNumber,
                                                RoleId = r.Id
                                            }).First();
            outsourceUserViewModel.OutsourceIds = GetOutsourceIdsByUserId(outsourceUserViewModel.Id);
            return outsourceUserViewModel;
        }

        public List<int> GetOutsourceIdsByUserId(int id)
        {
            return ( from oou in _context.OutsourcesOutsourceUsers
                     join o in _context.Outsources on oou.OutsourceId equals o.Id
                     where oou.OutsourceUserId == id && !o.IsDeleted
                     select o.Id ).ToList();
        }
    }
}
