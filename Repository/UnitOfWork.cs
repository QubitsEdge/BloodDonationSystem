using BloodDonationSystem.Model;

namespace BloodDonationSystem.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            donorRepository = new DonorRepository(_appDbContext);
            inventoryRepository = new InventoryRepository(_appDbContext);
        }

        public IDonorRepository donorRepository { get; }
        public IInventoryRepository inventoryRepository { get;}
        
        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }
    }
}
