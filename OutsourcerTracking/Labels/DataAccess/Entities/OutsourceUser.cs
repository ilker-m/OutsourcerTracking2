using OutsourcerTracking.Labels.Core.Entities;
using OutsourcerTracking.Labels.Core.Entities.Abilities;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class OutsourceUser : IEntity
    {
        public int Id { get; set; }
        public User User { get; set; }
        public ICollection<OutsourcesOutsourceUsers> Outsources { get; set; }
    }
}
