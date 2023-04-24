using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBookEntityLayer.Entities
{
    [Table("MemberPhones")]
    public class MemberPhone : Base<int>
    {
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string FriendNameSurname { get; set; }

        public byte PhoneTypeId { get; set; } //ForeignKey

        [Required]
        [StringLength(13, MinimumLength = 13)] //+905302794998
        public string Phone { get; set; }

        public string MemberId { get; set; } 
        
        //ForeignKey
        [ForeignKey("PhoneTypeId")]
        public virtual PhoneType PhoneType { get; set; }

        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }
    }
}
