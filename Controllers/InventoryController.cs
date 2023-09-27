using BloodDonationSystem.Model;
using BloodDonationSystem.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        public InventoryRepository _inventoryRepository;

        public InventoryController()
        {
            _inventoryRepository = new InventoryRepository();
        }

        [HttpGet]
        public ActionResult<List<Inventory>> GetAllInventory()
        {
            return _inventoryRepository.GetAllInventory();
        }

        [HttpGet("{bloodGroup}")]
        public ActionResult<Inventory> GetInventoryByBloodGroup(string bloodGroup)
        {
            return _inventoryRepository.GetInventoryByBloodGroup(bloodGroup);
        }

        /*[HttpPost]
        public void AddInventory(Inventory inventory) { 
            _inventoryRepository.AddInventory(inventory);
        }*/

        [HttpPut]
        public void UpdateInventory(Inventory inventory)
        {
            _inventoryRepository.UpdateInventory(inventory);
        }
    }
}
