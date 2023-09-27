using BloodDonationSystem.Model;

namespace BloodDonationSystem.Repository
{
    public class InventoryRepository : IInventory
    {
        private AppDbContext _context;
        public InventoryRepository() {
            _context = new AppDbContext();
        }

        public void AddInventory(Inventory inventory)
        {
            _context.Inventory.Add(inventory);
            _context.SaveChanges();
        }

        public void RemoveInventory(Inventory inventory)
        {
            _context.Inventory.Remove(inventory);
            _context.SaveChanges();
        }

        public List<Inventory> GetInventory()
        {
            return _context.Inventory.ToList();
        }

        public Inventory GetInventoryByBloodGroup(string bloodGroup)
        {
            return _context.Inventory.FirstOrDefault(inventory => inventory.BloodGroup == bloodGroup) ?? new Inventory();
        }

        public void UpdateInventory(Inventory inventory)
        {
            Inventory inventoryToUpdate = GetInventoryByBloodGroup(inventory.BloodGroup);
            inventoryToUpdate.Quantity = inventory.Quantity;
            _context.SaveChanges();
        }

        
    }
}
