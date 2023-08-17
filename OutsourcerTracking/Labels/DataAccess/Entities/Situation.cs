using OutsourcerTracking.Labels.Core.Entities;
using OutsourcerTracking.Labels.Core.Entities.Abilities;
using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class Situation : IEntity, IDeletable, ITrackable
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [StringLength(100)]
        [Required]
        public string Description { get; set; }
        public ICollection<OutsourceWorkOrder> OutsourceWorkOrders { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
