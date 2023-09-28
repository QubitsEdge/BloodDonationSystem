using BloodDonationSystem.Model;

namespace BloodDonationSystem.Repository
{
    public interface IInventoryRepository
    {
        void AddInventory(Inventory inventory);

        void UpdateInventory(Inventory inventory);

        List<Inventory> GetAllInventory();

        Inventory GetInventoryByBloodGroup(string bloodGroup);

        void RemoveInventory(Inventory inventory);
    }
}
