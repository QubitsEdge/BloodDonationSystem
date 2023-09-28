using BloodDonationSystem.Model;
using BloodDonationSystem.Repository;
using Microsoft.EntityFrameworkCore;

namespace BloodDonationSystem.UnitOfWorkPatterns
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDBContext _dbContext;

        public UnitOfWork(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            Donar = new DonarRepository(_dbContext);
            Inventory = new InventoryRepository(_dbContext);

        }
        public IDonarRepository Donar { get;}
        public IInventoryRepository Inventory { get;  }


        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
