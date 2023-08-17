using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Models.OutsouceUserModels
{
    public class OutsourceUserCreateViewModel
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;
        [Required]
        [StringLength(50)]
        public string FirstName { get { return _firstName; } set { _firstName = value.Trim(); } }
        [Required]
        [StringLength(50)]
        public string LastName { get { return _lastName; } set { _lastName = value.Trim(); } }
        [Required]
        [EmailAddress]
        [StringLength(256)]
        public string Email { get { return _email; } set { _email = value.Trim(); } }
        [Required]
        [StringLength(50)]
        public string Phone { get { return _phone; } set { _phone = value.Trim(); } }
        [Required]
        public int RoleId { get; set; }
        [Required]
        public List<int> OutsourceIds { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
