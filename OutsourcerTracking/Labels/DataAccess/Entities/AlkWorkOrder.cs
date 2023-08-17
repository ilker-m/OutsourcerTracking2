using OutsourcerTracking.Labels.Core.Entities;
using OutsourcerTracking.Labels.Core.Entities.Abilities;
using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class AlkWorkOrder : IEntity, IDeletable, ITrackable
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string ReferenceWorkOrderNo { get; set; }
        [StringLength(50)]
        [Required]
        public string OrderGroup { get; set; }
        [StringLength(50)]
        [Required]
        public string StockCode { get; set; }
        [StringLength(50)]
        [Required]
        public string StockName { get; set; }
        public ICollection<OutsourceWorkOrder>? OutsourceWorkOrders { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
