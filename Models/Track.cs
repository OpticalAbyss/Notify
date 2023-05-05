using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotifyWebApp.Models
{
    public class Track
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Artist")]
        public int Artist_ID { get; set; } 
        public Artist Artist { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Duration { get; set; }
        
        [Required]
        public string Path { get; set; }
        
        public string Image { get; set; }
    }
}
