using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_management.Models
{
    public class Concerner
    {
        //many-to-many relation require double key and virtual link
        [Column(Order = 0)]
        public int ReservationId { get; set; }
        [Column(Order = 1)]
        public int ChamberId { get; set; }
        public virtual Reservation Reservations { get;set; }
        public virtual Chambre Chambres { get; set; }

        public int NbAdultes { get; set; }
        public int NbEnfant { get; set; }
        public DateTime DateErrival { get; set; }
        public DateTime DateDeparture { get; set; }
    }
}
