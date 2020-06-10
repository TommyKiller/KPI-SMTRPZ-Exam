using Microsoft.EntityFrameworkCore;

namespace StorageApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<FoodStorageRoom> FoodStorageRooms { get; set; }
        public DbSet<StorageRoom> StorageRooms { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<FoodProduct> FoodProducts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
