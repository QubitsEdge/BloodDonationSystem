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
        public readonly IUnitOfWork _unitOfWork;

        public InventoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        [HttpGet]
        public ActionResult<List<Inventory>> GetAllInventory()
        {
            return _unitOfWork.inventoryRepository.GetAllInventory();
        }

        [HttpGet("{bloodGroup}")]
        public ActionResult<Inventory> GetInventoryByBloodGroup(string bloodGroup)
        {
            return _unitOfWork.inventoryRepository.GetInventoryByBloodGroup(bloodGroup);
        }

        /*[HttpPost]
        public void AddInventory(Inventory inventory)
        {
            _unitOfWork.inventoryRepository.AddInventory(inventory);
        }*/

        [HttpPut("update")]
        public void UpdateInventory(Inventory inventory)
        {
            _unitOfWork.inventoryRepository.UpdateInventory(inventory);
        }
    }
}
