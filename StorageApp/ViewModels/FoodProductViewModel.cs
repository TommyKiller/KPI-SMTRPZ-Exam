using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StorageApp.ViewModels
{
    public class FoodProductViewModel
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        public string About { get; set; }

        [Required]
        public float Volume { get; set; }

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
