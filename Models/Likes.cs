using System.ComponentModel.DataAnnotations;

namespace NotifyWebApp.Models
{
    public class Likes
    {
        [Required]
        public int User_ID { get; set; }

        [Required]
        public int Track_ID { get; set; }
    }
}
