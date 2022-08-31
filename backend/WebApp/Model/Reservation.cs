using System.ComponentModel.DataAnnotations;

namespace WebApp.Model
{
    public class Reservation
    {
        [Required]
        public int ReservationId { get; set; }
        [Required]
        public int ShowingId { get; set; }
        public int RowNumber { get; set; }
        [Required]
        public int ColumnNumber { get; set; }
        public DateTime ReservationExpirationDate { get; set; }
        public int TicketId { get; set; }

        //navigation property for ef core
        public Showing? Showing { get; set; }
        public Ticket? Ticket { get; set; }
    }
}