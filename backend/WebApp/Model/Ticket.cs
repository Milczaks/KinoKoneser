using System.ComponentModel.DataAnnotations;

namespace WebApp.Model
{
    public class Ticket
    {
        [Key]
        [Required]
        public int TicketId { get; set; }

        public string QRString { get; set; } = string.Empty;

        public string QRStringImage { get; set; } = string.Empty;

        public DateTime PurchaseDate { get; set; }


        //navigation property for ef core
        public List<Reservation>? Reservations { get; set; }
    }
}
