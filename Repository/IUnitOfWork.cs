namespace BloodDonationSystem.Repository
{
    public interface IUnitOfWork
    {
        IDonorRepository donorRepository { get; }
        IInventoryRepository inventoryRepository { get; }

        void SaveChanges();
    }
}
