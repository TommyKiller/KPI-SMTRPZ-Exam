using StorageApp.Models;
using System;

namespace StorageApp.Interfaces
{
    public interface IProductManager
    {
        public Product GetProductById(int id);
        public FoodProduct GetFoodProductById(int id);
        public Product AddProduct(string name, string about, float Volume, StorageRoom room);
        public FoodProduct AddProduct(string name, string about, float Volume, FoodStorageRoom room, DateTime manufactureDate, DateTime expirationDate, float minTemp, float maxTemp);
    }
}
