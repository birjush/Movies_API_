using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    public class Movies
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Industry { get; set; }
        [Required]
        public string Synopsis { get; set; }
    }
}
