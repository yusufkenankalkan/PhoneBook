using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBookEntityLayer.Entities
{
    public abstract class Base<T> //Generic
    {
        [Column(Order = 1)]
        [Key] //Primary key olmasını sağlıyor.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //identity(1,1)
        public T Id { get; set; }

        [Column(Order = 2)]
        public DateTime CreatedDate { get; set; }
        public bool IsRemoved { get; set; }
    }
}
