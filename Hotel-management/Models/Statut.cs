using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
namespace Hotel_management.Models
{
    public class Statut
    {
        [Key]
        public int StatutId { get; set; }
        public string Libelle { get; set; }
        public ICollection<Facture> factures { get; set; }
    }
}
