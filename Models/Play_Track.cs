using System.ComponentModel.DataAnnotations;

namespace NotifyWebApp.Models
{
    public class Play_Track
    {
        [Required]
        public int Playlist_ID { get; set; }
        
        [Required]
        public int Track_ID { get; set; }
    }
}
