using OutsourcerTracking.Labels.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class IntegrationStatus : IEntity
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<OutsourceWorkOrder> OutsourceWorkOrders { get; set; }
    }
}
