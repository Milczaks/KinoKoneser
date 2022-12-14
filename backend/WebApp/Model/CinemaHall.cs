using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApp.Model
{
        public class CinemaHall
        {
            [Key]
            [Required]
            public int CinemaHallId { get; set; }
            [Required]
            public string? CinemaHallName { get; set; }
            [Required]
            [Range(1, int.MaxValue, ErrorMessage = "Value out of range")]
            public int RowCount { get; set; }
            [Required]
            [Range(1, int.MaxValue, ErrorMessage = "Value out of range")]
            public int ColumnCount { get; set; }

        //navigation property for ef core
        [JsonIgnore]
        public List<Showing>? Showings { get; set; }
    }
}
