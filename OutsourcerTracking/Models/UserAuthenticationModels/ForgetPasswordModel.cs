using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Models.UserAuthenticationModels
{
    public class ForgetPasswordModel
    {
        [Required(ErrorMessage = "Zorunlu Alandır.")]
        [EmailAddress(ErrorMessage = "Lütfen Epostanızı giriniz")]
        public string Email { get; set; }
    }
}
