using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace BloodDonationSystem.Model
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    /*var configBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        //    var configSection = configBuilder.GetSection("ConnectionStrings");
        //    var connectionString = configSection["Hbdonation"];
        //    optionsBuilder.UseSqlServer(connectionString);*/
        //}


        public DbSet<Donar> Donar { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Donar>().Property(x => x.DonarId).HasDefaultValueSql("NEWID()");

        }


    }
}
