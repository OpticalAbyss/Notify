using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotifyWebApp.Models
{
    public class Play_Track
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("Playlist")]
        public int Playlist_ID { get; set; }
        public Playlist Playlist { get; set; }

        [Required]
        [ForeignKey("Track")]
        public int Track_ID { get; set; }
        public Track Track { get; set; } 
    }
}
