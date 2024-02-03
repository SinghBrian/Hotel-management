using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
namespace Hotel_management.Models
{

    public class Tarifs
    {
        [Key]
        public int TarifsId { get; set; }
        public int PrixCat { get; set; }

        public ICollection<Saison> Saisons { get; set; }
    }
}
