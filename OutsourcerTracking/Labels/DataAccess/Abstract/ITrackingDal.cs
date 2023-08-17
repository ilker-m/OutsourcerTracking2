using OutsourcerTracking.Labels.Core.DataAccess;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.OutsourceHomeModels;

namespace OutsourcerTracking.Labels.DataAccess.Abstract
{
    public interface ITrackingDal : IEntityRepository<Tracking>
    {
        bool AnyNotSealedByOutsourceWorkOrderId(int id);
        Tracking GetToCancelSealedByOutsourceWorkOrderId(int outsourceWorkOrderId);
        decimal GetTotalByOutsourceWorkOrderId(int id);
    }
}
