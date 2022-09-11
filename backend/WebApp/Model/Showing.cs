using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

        //navigation property for ef core
        [JsonIgnore]
        public CinemaHall? CinemaHall { get; set; }
        [JsonIgnore]
        public Movie? Movie { get; set; }
        [JsonIgnore]
        public List<Ticket>? Tickets { get; set; }
    }
}
