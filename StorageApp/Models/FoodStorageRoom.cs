using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StorageApp.Models
{
    public class FoodStorageRoom : Room
    {
        [Required]
        public float AverageTemperature { get; set; }

        public IEnumerable<FoodProduct> Products { get; set; }
    }
}
