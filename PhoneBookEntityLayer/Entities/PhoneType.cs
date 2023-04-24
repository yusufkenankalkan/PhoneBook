using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBookEntityLayer.Entities
{
    [Table("PhoneTypes")]
    public class PhoneType : Base<byte>
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
    }
}
