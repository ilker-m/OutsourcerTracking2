using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Models.APIModels
{
    public class GetWorkOrderDetailsModel
    {
        public List<GetReceiveWithUsersModel> Receives { get; set; }
        public List<Tracking> Trackings { get; set; }
    }
}
