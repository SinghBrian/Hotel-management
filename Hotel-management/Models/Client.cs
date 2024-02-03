namespace Hotel_management.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string TelephoneNumber { get; set; }
        public string email { get; set; } 
        public virtual ICollection<Commentaire>? Comments { get; set; }
        public virtual ICollection<Reservation>? Reservations { get; set; }
    }
}
