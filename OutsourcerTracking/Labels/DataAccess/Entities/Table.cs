using OutsourcerTracking.Labels.Core.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class Table : IEntity
    {
        public int Id { get; set; }
        public bool IsChanged { get; set; }
    }
}
