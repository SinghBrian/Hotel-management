using MessagePack;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Hotel_management.Models
{
    public class Hotels
    {
        [Key]
        public int HotelsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Criteria_stars { get; set; }
        public string Criteria_size { get; set; }
        public int Capacity_Max { get; set; }
        public string destination { get; set; }

        public virtual ICollection<Chambre>? Chambre { get; set; }

        public virtual ICollection<Services_Supplementaire>? Services_Supplementaire { get;set; }
        public virtual ICollection<Commentaire>? Commentaire { get; set; }
    }
}
