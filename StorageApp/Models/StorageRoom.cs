using System.Collections.Generic;

namespace StorageApp.Models
{
    public class StorageRoom : Room
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
