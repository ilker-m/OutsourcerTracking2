using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.Core.Entities;
using OutsourcerTracking.Labels.Core.Entities.Abilities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class OutsourceWorkOrder : IEntity,  IDeletable, ITrackable
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        public int RawMaterialsWarehouseCode { get; set; }
        [Required]
        public int ProductWarehouseCode { get; set; }
        [Required]
        [StringLength(50)]
        public string ColorCode { get; set; }
        [Required]
        [StringLength(50)]
        public string ColorName { get; set; }
        public int AlkWorkOrderId { get; set; }
        public AlkWorkOrder? AlkWorkOrder { get; set; }
        public int OperationId { get; set; }
        public Operation? Operation { get; set; }
        public int OutsourceId { get; set; }
        public Outsource? Outsource { get; set; }
        public int SituationId { get; set; }
        public Situation? Situation { get; set; }
        public int IntegrationStatusId { get; set; }
        public virtual IntegrationStatus? IntegrationStatus { get; set; }
        [StringLength(50)]
        [Required]
        public string WorkOrderNo { get; set; }
        [Precision(14, 2)]
        public decimal Amount { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime WorkOrderDate { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime? ReceivedDate { get; set; }
        [Required]
        [StringLength(50)]
        public string AlkUserName { get; set; }
        [Required]
        [StringLength(50)]
        public string AlkNormalizedUserName { get; set; }
        public ICollection<Receive>? Receives { get; set; }
        public ICollection<Tracking>? Trackings { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
