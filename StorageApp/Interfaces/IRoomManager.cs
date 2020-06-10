using StorageApp.Models;

namespace StorageApp.Interfaces
{
    public interface IRoomManager
    {
        public StorageRoom GetRoomById(int id);
        public FoodStorageRoom GetFoodStorageRoom(int id);
        public StorageRoom AddRoom(float overallSpace, float freeSpace);
        public FoodStorageRoom AddRoom(float overallSpace, float freeSpace, float averageTemp);
        public void PlaceProduct(int roomId, in Product product);
        public void PlaceProduct(int roomId, FoodProduct product);
        public bool EnoughSpace(int roomId, float volume);
    }
}
