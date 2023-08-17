using Newtonsoft.Json.Serialization;
using OutsourcerTracking.Labels.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Models.UserAuthenticationModels
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        public string oldPassword { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        [Compare(nameof(NewPassword), ErrorMessage = "Şifre Alanları Aynı Olmak Zorundadır.")]
        [MinLength(6, ErrorMessage = "En az 6 karakterli olmalıdır")]
        public string NewPasswordAgain { get; set; }
        
    }
}
