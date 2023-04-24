using PhoneBookEntityLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace PhoneBookEntityLayer.ViewModels
{
    public class MemberPhoneViewModel
    {

        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public bool IsRemoved { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        [RegularExpression(@"^([a-zA-zğüşöçıİĞÜŞÖÇ]+\s+[a-zA-zğüşöçıİĞÜŞÖÇ]*)*$", ErrorMessage = "İsim soyisimde harf dışında karakter olamaz")]
        [Display(Name = "İsim Soyisim")]
        public string FriendNameSurname { get; set; }

        public byte PhoneTypeId { get; set; } //ForeignKey

        [Required]
        [StringLength(13, MinimumLength = 13)] //+905302794998
        [RegularExpression("^[+][0-9]*", ErrorMessage = "Telefon  +XXXXXXXXXXXX şeklinde rakamlardan oluşmalıdır")]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }


        public string MemberId { get; set; } //ForeignKey
        public PhoneType? PhoneType { get; set; }

        public Member? Member { get; set; }
        public string? AnotherPhoneTypeName { get; set; }
    }
}
