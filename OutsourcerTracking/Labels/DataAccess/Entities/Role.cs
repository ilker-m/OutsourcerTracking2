using Microsoft.AspNetCore.Identity;
using OutsourcerTracking.Labels.Core.Entities;
using OutsourcerTracking.Labels.Core.Entities.Abilities;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class Role : IdentityRole<int>, IEntity, IDeletable, ITrackable
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
