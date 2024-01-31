using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    public class User
    {
        [Key]
        public string Key{ get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
