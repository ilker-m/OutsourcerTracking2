using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Models.UserAuthenticationModels
{
    public class UserAuthenticationLoginViewModel
    {
        private string _email;
        [Required]
        [EmailAddress]
        public string Email { get { return _email; } set { _email = value.Trim(); } }
        [Required]
        public string Password { get; set; }
    }
}
