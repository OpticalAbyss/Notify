using System.ComponentModel.DataAnnotations;

namespace NotifyWebApp.Models
{
    public class Artist
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Genre { get; set; }
        
        public string  Image { get; set; }
    }
}
