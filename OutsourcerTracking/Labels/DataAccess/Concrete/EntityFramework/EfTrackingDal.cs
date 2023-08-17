using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.Core.DataAccess.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.OutsourceHomeModels;
using System.Linq;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    public class EfTrackingDal : EfEntityRepositoryBase<Tracking, ApplicationIdenityDbContext>, ITrackingDal
    {
        private readonly ApplicationIdenityDbContext _context;
        public EfTrackingDal() { }
        public EfTrackingDal(ApplicationIdenityDbContext context)
        {
            _context = context;
        }
        public bool AnyNotSealedByOutsourceWorkOrderId(int id)
        {
            return _context.Trackings.Any(t => t.OutsourceWorkOrderId == id && !t.IsDeleted && !t.IsSealed);
        }
        public Tracking GetToCancelSealedByOutsourceWorkOrderId(int outsourceWorkOrderId)
        {
            return _context.Trackings.Where(t => !t.IsDeleted && t.Date >= DateTime.Now.AddMinutes(-30) && t.IsSealed && t.OutsourceWorkOrderId == outsourceWorkOrderId).OrderByDescending(t => t.Date).FirstOrDefault();
        }
        public decimal GetTotalByOutsourceWorkOrderId(int id)
        {
            return _context.Trackings.Where(t => t.OutsourceWorkOrderId == id && !t.IsDeleted).GroupBy(t => t.OutsourceWorkOrderId).Select(t => t.Sum(t => t.Amount)).Sum();
        }
    }
}
