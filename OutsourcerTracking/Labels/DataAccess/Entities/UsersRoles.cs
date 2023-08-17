using Microsoft.AspNetCore.Identity;
using OutsourcerTracking.Labels.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Labels.DataAccess.Entities
{
    public class UsersRoles : IdentityUserRole<int>, IEntity
    {
        public int Id { get; set; }
    }
}
