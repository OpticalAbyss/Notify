using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotifyWebApp.Models
{
    public class Likes
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; } 

        [Required]
        [ForeignKey("Track")]
        public int Track_ID { get; set; }
        public Track Track { get; set; }
    }
}
