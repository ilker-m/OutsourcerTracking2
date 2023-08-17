using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.Core.DataAccess.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.APIModels;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    public class EfReceiveDal : EfEntityRepositoryBase<Receive, ApplicationIdenityDbContext>, IReceiveDal
    {
        private readonly ApplicationIdenityDbContext _context;
        public EfReceiveDal() { }
        public EfReceiveDal(ApplicationIdenityDbContext context)
        {
            _context = context;
        }

        public bool AnyNotSealedByOutsourceWorkOrderId(int id)
        {
            return _context.Recieves.Any(r => r.OutsourceWorkOrderId == id && !r.IsDeleted && !r.IsSealed);
        }

        public List<GetReceiveWithUsersModel> GetReceivesWithUsersByOutsourceWorkOrderId(int id)
        {
            return ( from r in _context.Recieves
                     join u in _context.Users on r.OutsourceWorkOrderId equals u.Id
                     where !r.IsDeleted && r.OutsourceWorkOrderId == id
                     select new GetReceiveWithUsersModel
                     {
                         Id = r.Id,
                         OutsourceWorkOrderId = r.OutsourceWorkOrderId,
                         EmployeeUserId = r.EmployeeUserId,
                         EmployeeFirstName = u.FirstName,
                         EmployeeLastname = u.LastName,
                         Date = r.Date,
                         Amount = r.Amount,
                         IsSealed = r.IsSealed,
                         ApprovedDate = r.ApprovedDate,
                     } ).ToList();
        }

        public Receive GetOrderedLastDateByOutsourceWorkOrderId(int id)
        {
            return _context.Recieves.Where(r => r.OutsourceWorkOrderId == id && !r.IsDeleted).OrderByDescending(o => o.Date).FirstOrDefault();
        }

        public Receive GetToCancelSealedByOutsourceWorkOrderId(int outsourceWorkOrderId)
        {
            return _context.Recieves.Where(r => !r.IsDeleted && r.Date >= DateTime.Now.AddMinutes(-30) && r.IsSealed && r.OutsourceWorkOrderId == outsourceWorkOrderId).OrderByDescending(t => t.Date).FirstOrDefault();
        }

        public decimal GetTotalByOutsourceWorkOrderId(int id)
        {
            return _context.Recieves.Where(r => r.OutsourceWorkOrderId == id && !r.IsDeleted).GroupBy(t => t.OutsourceWorkOrderId).Select(t => t.Sum(t => t.Amount)).Sum();
        }

        public bool AnyNotApprovedByOutsourceWorkId(int id)
        {
            return _context.Recieves.Any(r => r.OutsourceWorkOrderId == id && !r.IsDeleted && r.ApprovedDate == null);
        }
    }
}
