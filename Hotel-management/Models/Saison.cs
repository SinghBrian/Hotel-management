using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Hotel_management.Models
{
    public class Saison
    {
        [Key]
        public int SaisonId { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin {get; set; }

        public string Libelle { get; set; }
    }
}
