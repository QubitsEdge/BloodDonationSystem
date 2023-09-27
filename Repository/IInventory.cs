using BloodDonationSystem.Model;

namespace BloodDonationSystem.Repository
{
    public interface IInventory
    {
        void AddInventory(Inventory inventory);

        void UpdateInventory(Inventory inventory);

        List<Inventory> GetInventory();

        Inventory GetInventoryByBloodGroup(string bloodGroup);

        void RemoveInventory(Inventory inventory);
    }
}
