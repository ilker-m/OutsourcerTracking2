using OutsourcerTracking.Labels.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using OutsourcerTracking.Labels.Core.Entities.Abilities;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class User : IdentityUser<int>, IEntity, IDeletable, ITrackable
    {
        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Required]
        public string LastName { get; set; }
        public OutsourceUser OutsourceUser { get; set; }
        public EmployeeUser EmployeeUser { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public bool IsFirst { get; set; }
        [StringLength(50)]
        public string? KeyCode { get; set; }
    }
}
