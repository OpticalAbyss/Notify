using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotifyWebApp.Models
{
    public class Follower
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("User")]
        public int User_ID { get; set; }
        public User User { get; set; } 

        [Required]
        [ForeignKey("Artist")]
        public int Artist_ID { get; set; }
        public Artist Artist { get; set; }  
    }
}
