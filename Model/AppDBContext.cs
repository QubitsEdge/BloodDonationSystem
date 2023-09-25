using Microsoft.EntityFrameworkCore;
namespace BloodDonationSystem.Model
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base()
        { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var configSection = configBuilder.GetSection("ConnectionStrings");

            var connectionString = configSection["Hbdonation"];

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Donar>().Property(x => x.Id).HasDefaultValue("NewGuid");
        }

        public DbSet<Donar> Donar { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
    }

    
}
