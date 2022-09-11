using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApp.Model
{
    public class Movie
    {
        [Key]
        [Required]
        public int movieId { get; set; }
        [Required]
        public string title { get; set; } = string.Empty;
        [Required]
        public string description { get; set; } = string.Empty;
        [Required]
        public int year { get; set; }
        [Required]
        public int length { get; set; }
        public string posterURL { get; set; } = string.Empty;

        //navigation property for ef core
        [JsonIgnore]
        public List<Showing> Showings { get; set; }

    }
}
