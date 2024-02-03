using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Hotel_management.Models
{
    public class Categorie
    {
        [Key]
        public int CategoriesId { get; set; }
        public string libelle { get; set; }
        public int MaxPersonne { get; set; }
        public ICollection<Chambre> ChambreCat { get; set;}
        public ICollection<Tarifs> TarifsCat { get; set;}
    }
}
