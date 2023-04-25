using System.ComponentModel.DataAnnotations;

namespace NotifyWebApp.Models
{
    public class Track
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Duration { get; set; }
        
        [Required]
        public string Path { get; set; }
        
        public string Image { get; set; }
    }
}
