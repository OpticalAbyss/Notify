using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotifyWebApp.Models
{
    public class Playlist
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        [Required]
        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; }  
    }
}
