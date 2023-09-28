using System.Collections.Generic;

namespace BloodDonationSystem.Model
{
    public interface IInventoryRepository
    {
        List<Inventory> GetAll();
        Inventory GetByBloodGroup(string bloodGroup);
        void Update(Inventory inventory);

        void Insert(Inventory inventory);
        void Save();
        void Delete(string id);
        Inventory GetById(string id);


    }
}
