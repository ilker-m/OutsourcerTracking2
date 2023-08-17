using System.ComponentModel;

namespace OutsourcerTracking.Labels.Core.Entities.Abilities
{
    public interface IDeletable
    {
        [DefaultValue(false)]
        bool IsDeleted { get; set; }
    }
}
