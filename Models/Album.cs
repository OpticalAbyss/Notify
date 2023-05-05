using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace NotifyWebApp.Models
{
    public class Album
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        //Foreign Key
        [ForeignKey("Artist")]
        public string Atrist { get; set; }
        public Artist Artist { get; set; } 

        public string Image { get; set; }
    }
}
