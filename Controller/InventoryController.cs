using BloodDonationSystem.Model;
using BloodDonationSystem.Repository;
using BloodDonationSystem.UnitOfWorkPatterns;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BloodDonationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IInventoryRepository _inventoryRepository;

        /*public InventoryController(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }*/

        public InventoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //_inventoryRepository = new InventoryRepository();
        }

        // GET: api/Inventory
        [HttpGet]
        public List<Inventory> GetInventories()
        {
            var inventories = _unitOfWork.Inventory.GetAll();
            return inventories;
        }

        // GET: api/Inventory/5
        [HttpGet("{BloodGroup}")]
        public ActionResult<Inventory> GetInventoryUsingBloodGroup([FromRoute] string BloodGroup)
        {
            var inventory = _unitOfWork.Inventory.GetByBloodGroup(BloodGroup);
            return inventory;
        }


        // POST: api/Inventory
        /*[HttpPost]
        public ActionResult<Inventory> InsertInventory([FromBody] Inventory inventory)
        {
            
            var existingInventory = _inventoryRepository.GetByBloodGroup(inventory.BloodGroup);

            if (existingInventory != null)
            {
                existingInventory.Quantity = inventory.Quantity;
                _inventoryRepository.Update(existingInventory);
            }
            else
            {
                _inventoryRepository.Insert(inventory);
            }

            _inventoryRepository.Save();
            return CreatedAtAction(nameof(GetInventory), new { bloodGroup = inventory.BloodGroup }, inventory);
        }*/


        // PUT: api/Inventory/5
        [HttpPut("{id}")]
        public IActionResult UpdateInventory(string BloodGroup, [FromBody] Inventory inventory)
        {
            

            var existingInventory = _unitOfWork.Inventory.GetById(BloodGroup);
            
            existingInventory.BloodGroup = inventory.BloodGroup;
            existingInventory.Quantity = inventory.Quantity;

            _unitOfWork.Inventory.Update(existingInventory);
            _unitOfWork.Inventory.Save();

            return NoContent(); 
        }

        // DELETE: api/Inventory/5
        [HttpDelete("{BloodGroup}")]
        public IActionResult DeleteInventory(string BloodGroup)
        {
            var inventory = _unitOfWork.Inventory.GetById(BloodGroup);
           

            _unitOfWork.Inventory.Delete(BloodGroup);
            _unitOfWork.Inventory.Save();

            return NoContent(); 
        }
    }
}
