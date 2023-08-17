using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Labels.Core.Entities.Abilities
{
    public interface ITrackable
    {
        [DefaultValue("")]
        [StringLength(50)]
        string? CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        [DefaultValue("")]
        [StringLength(50)]
        string? UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
    }
}
