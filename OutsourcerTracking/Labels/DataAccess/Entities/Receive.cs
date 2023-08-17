using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.Core.Entities;
using OutsourcerTracking.Labels.Core.Entities.Abilities;
using System.ComponentModel;
using System.Reflection;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class Receive : IEntity, IDeletable, ITrackable
    {
        public int Id { get; set; }
        public int OutsourceWorkOrderId { get; set; }
        public OutsourceWorkOrder OutsourceWorkOrder { get; set; }
        public int EmployeeUserId { get; set; }
        public EmployeeUser EmployeeUser { get; set; }
        public DateTime Date { get; set; }
        [Precision(14, 2)]
        public decimal Amount { get; set; }
        [DefaultValue(false)]
        public bool IsSealed { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
