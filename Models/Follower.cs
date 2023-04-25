using System.ComponentModel.DataAnnotations;

namespace NotifyWebApp.Models
{
    public class Follower
    {
        [Required]
        public int User_ID { get; set; }

        [Required]
        public int Artist_ID { get; set; }
    }
}
