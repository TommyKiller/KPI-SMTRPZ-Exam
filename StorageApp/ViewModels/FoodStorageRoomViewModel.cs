using System.ComponentModel.DataAnnotations;

namespace StorageApp.ViewModels
{
    public class FoodStorageRoomViewModel
    {
        [Required]
        public float OverallSpace { get; set; }

        [Required]
        public float FreeSpace { get; set; }

        [Required]
        public float AverageTemperature { get; set; }
    }
}
