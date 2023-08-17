using OutsourcerTracking.Labels.Core.Entities;
using OutsourcerTracking.Labels.Core.Entities.Abilities;
using OutsourcerTracking.Labels.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class Outsource : IEntity, IDeletable, ITrackable
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrentCode { get; set; }
        [Required]
        [StringLength(50)]
        public string WarehouseCode { get; set; }
        [Required]
        public int MachineNo { get; set; }
        [Required]
        [StringLength(50)]
        public string MachineCode { get; set; }
        [Required]
        [StringLength(100)]
        public string MachineName { get; set; }
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(150)]
        public string Address { get; set; }
        public ICollection<OutsourcesOutsourceUsers>? OutsourcesOutsourceUsers { get; set; }
        public ICollection<OutsourceWorkOrder>? OutsourceWorkOrders { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
