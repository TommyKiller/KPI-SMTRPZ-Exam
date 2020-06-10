using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StorageApp.ViewModels
{
    public class StorageRoomViewModel
    {
        [Required]
        public float OverallSpace { get; set; }

        [Required]
        public float FreeSpace { get; set; }
    }
}
