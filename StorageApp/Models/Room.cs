using System.ComponentModel.DataAnnotations;

namespace StorageApp.Models
{
    abstract public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public float OverallSpace { get; set; }

        [Required]
        public float FreeSpace { get; set; }
    }
}
