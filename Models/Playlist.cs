using System.ComponentModel.DataAnnotations;

namespace NotifyWebApp.Models
{
    public class Playlist
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Image { get; set; }

        [Required]
        public int User_ID { get; set; }
    }
}
