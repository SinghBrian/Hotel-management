using MessagePack;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
namespace Hotel_management.Models
{
    public class Services_Supplementaire
    {
        [Key]
        public int ServicesId { get; set; }
        public string ServicesName { get; set; }
        public float ServciesPrix { get; set; }

        //public virtual ICollection<Hotels>? Hotels { get; set; }
    }
}
