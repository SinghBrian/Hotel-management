namespace Hotel_management.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int Total { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ClientName { get; set; }

        public virtual ICollection<Facture>? Facts { get; set; }
        //public virtual ICollection<Concerner>? Concerners { get; set; } = new HashSet<Concerner>();
    }
}
