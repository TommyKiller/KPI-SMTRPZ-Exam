using StorageApp.Interfaces;
using StorageApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageApp.Controllers
{
    public class StorageController
    {
        private IProductManager _productManager { get; set; }
        private IRoomManager _roomManager { get; set; }

        public StorageController(IProductManager productManager, IRoomManager roomManager)
        {
            _productManager = productManager;
            _roomManager = roomManager;
        }

        public void RegisterProduct(ProductViewModel model)
        {
            throw new NotImplementedException();
        }

        public void RegisterProduct(FoodProductViewModel model)
        {
            throw new NotImplementedException();
        }

        public void RegisterRoom(StorageRoomViewModel model)
        {
            throw new NotImplementedException();
        }

        public void RegisterRoom(FoodStorageRoomViewModel model)
        {
            throw new NotImplementedException();
        }

        public void PlaceProduct(int productId, int roomId)
        {
            throw new NotImplementedException();
        }
    }
}
