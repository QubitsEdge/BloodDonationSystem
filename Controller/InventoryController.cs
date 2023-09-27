using BloodDonationSystem.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BloodDonationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryRepository _inventoryRepository;

        /*public InventoryController(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }*/

        public InventoryController()
        {
            _inventoryRepository = new InventoryRepository();
        }

        // GET: api/Inventory
        [HttpGet]
        public List<Inventory> GetInventories()
        {
            var inventories = _inventoryRepository.GetAll();
            return inventories;
        }

        // GET: api/Inventory/5
        [HttpGet("{BloodGroup}")]
        public ActionResult<Inventory> GetInventory([FromRoute] string BloodGroup)
        {
            var inventory = _inventoryRepository.GetByBloodGroup(BloodGroup);
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
            

            var existingInventory = _inventoryRepository.GetById(BloodGroup);
            
            existingInventory.BloodGroup = inventory.BloodGroup;
            existingInventory.Quantity = inventory.Quantity;

            _inventoryRepository.Update(existingInventory);
            _inventoryRepository.Save();

            return NoContent(); 
        }

        // DELETE: api/Inventory/5
        [HttpDelete("{BloodGroup}")]
        public IActionResult DeleteInventory(string BloodGroup)
        {
            var inventory = _inventoryRepository.GetById(BloodGroup);
           

            _inventoryRepository.Delete(BloodGroup);
            _inventoryRepository.Save();

            return NoContent(); 
        }
    }
}
