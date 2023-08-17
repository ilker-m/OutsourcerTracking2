using OutsourcerTracking.Labels.Core.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class OutsourcesOutsourceUsers : IEntity
    {
        public int Id { get; set; }
        public int OutsourceId { get; set; }
        public int OutsourceUserId { get; set; }
        public Outsource Outsource { get; set; }
        public OutsourceUser OutsourceUser { get; set; }
    }
}
