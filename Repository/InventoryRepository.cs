using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BloodDonationSystem.Model
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly AppDBContext _context;

        public InventoryRepository(AppDBContext context)
        {
            _context = context;
        }

        public InventoryRepository()
        {
            _context = new AppDBContext();
        }

        public List<Inventory> GetAll()
        {
            return _context.Inventory.ToList();
        }

        public Inventory GetByBloodGroup(string bloodGroup)
        {
            return _context.Inventory.FirstOrDefault(i => i.BloodGroup == bloodGroup);
        }

        public Inventory GetById(string id)
        {
            return _context.Inventory.FirstOrDefault(i => i.BloodGroup == id);
        }

        /*public List<Donar> GetDonarsByInventoryId(int inventoryId)
        {
            return _context.Inventory
                .Include(i => i.DonarList)
                .FirstOrDefault(i => i.IdForBloodCollection == inventoryId)
                ?.DonarList;
        }*/
        public void Update(Inventory inventory)
        {
            _context.Inventory.Update(inventory);
            _context.SaveChanges();
        }

        public void Insert(Inventory inventory)
        {
            _context.Inventory.Add(inventory);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var inventoryToDelete = _context.Inventory.Find(id);
            if (inventoryToDelete != null)
            {
                _context.Inventory.Remove(inventoryToDelete);
            }
        }
        

    }
}
