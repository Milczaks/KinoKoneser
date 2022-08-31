using System.ComponentModel.DataAnnotations;

namespace WebApp.Model
{
    public class CinemaHall
    {
        public class SinemaHall
        {
            [Key]
            [Required]
            public int CinemaHallId { get; set; }
            [Required]
            public string? CinemaHallName { get; set; }
            [Required]
            public int RowCount { get; set; }
            [Required]
            public int ColumnCount { get; set; }
        }

        public List<Showing> Showings { get; set; }
    }

}
}
