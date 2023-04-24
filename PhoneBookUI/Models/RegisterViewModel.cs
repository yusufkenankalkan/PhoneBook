
using System.ComponentModel.DataAnnotations;

namespace PhoneBookUI.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Ad Alanı Gereklidir")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="İsim maks. 50 min. 2 karakter olmalıdır!")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Soyisim Alanı Gereklidir")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Soyisim maks. 50 min. 2 karakter olmalıdır!")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Email Alanı Gereklidir")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Parola Alanı Gereklidir")]
        //NOT: RegEx ifadersi eklenecek
        public string Password { get; set; }


        [Required]
        [Compare("Password", ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ComparePassword { get; set; }


        public DateTime? BirthDate { get; set; }
        public byte? Gender { get; set; }
    }
}
