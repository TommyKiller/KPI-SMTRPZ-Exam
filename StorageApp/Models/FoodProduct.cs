using System;
using System.ComponentModel.DataAnnotations;

namespace StorageApp.Models
{
    public class FoodProduct : Product
    {
        [Required]
        public DateTime ManufactureDate { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        [Required]
        public float MinTemperature { get; set; }

        [Required]
        public float MaxTemperature { get; set; }
    }
}
