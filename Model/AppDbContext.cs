using Microsoft.EntityFrameworkCore;

namespace BloodDonationSystem.Model
{
    public class AppDbContext : DbContext
    { 

        public AppDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var configSection = configBuilder.GetSection("ConnectionStrings");

            var connectionString = configSection["BloodDonationConnection"];

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
