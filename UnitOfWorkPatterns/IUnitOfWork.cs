using BloodDonationSystem.Model;
using BloodDonationSystem.Repository;

namespace BloodDonationSystem.UnitOfWorkPatterns
{
    public interface IUnitOfWork
    {
        IDonarRepository Donar { get; }
        IInventoryRepository Inventory { get; }

        void SaveChanges();
    }
}
