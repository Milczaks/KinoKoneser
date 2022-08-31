using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class Showing
    {
        [Key]
        [Required]
        public int ShowingId { get; set; }
        [Required]
        public int CinemaHallId { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public double TicketPrice { get; set; }
        public bool Dubbing { get; set; }
        public bool Subtitles { get; set; }


        public CinemaHall? CinemaHall { get; set; }
        public Movie? Movie { get; set; }

        public List<Reservation>? Reservations { get; set; }
    }
}
}