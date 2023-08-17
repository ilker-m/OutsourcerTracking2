using OutsourcerTracking.Labels.Core.DataAccess;
using OutsourcerTracking.Labels.DataAccess.Entities;
using OutsourcerTracking.Models.APIModels;

namespace OutsourcerTracking.Labels.DataAccess.Abstract
{
    public interface IReceiveDal : IEntityRepository<Receive>
    {
        bool AnyNotSealedByOutsourceWorkOrderId(int id);
        List<GetReceiveWithUsersModel> GetReceivesWithUsersByOutsourceWorkOrderId(int id);
        Receive GetOrderedLastDateByOutsourceWorkOrderId(int id);
        Receive GetToCancelSealedByOutsourceWorkOrderId(int outsourceWorkOrderId);
        decimal GetTotalByOutsourceWorkOrderId(int id);
        bool AnyNotApprovedByOutsourceWorkId(int Id);
    }
}
