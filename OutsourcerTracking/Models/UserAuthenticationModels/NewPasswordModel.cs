using System.ComponentModel.DataAnnotations;

namespace OutsourcerTracking.Models.UserAuthenticationModels
{
    public class NewPasswordModel
    {
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]

        [MinLength(6, ErrorMessage = "En az 6 karakterli olmalıdır")]
        public string key { get; set; }



        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        //[Compare(nameof(NewPassword), ErrorMessage = "Şifre Alanları Aynı Olmak Zorundadır.")]
        [MinLength(6, ErrorMessage = "En az 6 karakterli olmalıdır")]
        public string newpassword { get; set; }

        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        [Compare(nameof(newpassword), ErrorMessage = "Şifre Alanları Aynı Olmak Zorundadır.")]
        [MinLength(6, ErrorMessage = "En az 6 karakterli olmalıdır")]
        public string newpassword2 { get; set; }
    }
}
