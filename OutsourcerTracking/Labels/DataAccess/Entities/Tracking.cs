using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.Core.Entities;
using OutsourcerTracking.Labels.Core.Entities.Abilities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class Tracking : IEntity, IDeletable, ITrackable
    {
        public int Id { get; set; }
        public int OutsourceWorkOrderId { get; set; }
        public DateTime Date { get; set; }
        [Precision(14, 2)]
        public decimal Amount { get; set; }
        public OutsourceWorkOrder OutsourceWorkOrder { get; set; }
        [DefaultValue(false)]
        public bool IsSealed { get; set; }
        [Required]
        [Precision(14, 2)]
        public decimal Weight_Kg { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
