using System.ComponentModel.DataAnnotations;

namespace NotifyWebApp.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Key]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Image { get; set; }
    }
}
