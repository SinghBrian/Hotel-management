using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_management.Models
{
    public class Commentaire
    {

        public int CommentaireId { get; set; }
        public string CommentaireTexte { get; set; }

        public string ClientName {get; set;}
        
    }
}
