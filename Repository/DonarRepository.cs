using Microsoft.EntityFrameworkCore;
using BloodDonationSystem.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BloodDonationSystem.Repository
{
    public class DonarRepository : IDonarRepository
    {
        private readonly AppDBContext _dbContext;
        public DonarRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        

        public void AddDonor(Donar donar)
        {
            _dbContext.Donar.Add(donar);
            _dbContext.SaveChanges();
        }

        public Donar GetByGuid(Guid id)
        {
            return _dbContext.Donar.ToList().FirstOrDefault(donor => donor.DonarId == id) ?? new Donar();
        }

        public List<Donar> GetAll()
        {
            return _dbContext.Donar.ToList();
        }

        public void UpdateDonor(Donar donor)
        {

            Donar donorToUpdate = GetByGuid(donor.DonarId);
            donorToUpdate.FirstName = donor.FirstName;
            donorToUpdate.LastName = donor.LastName;
            donorToUpdate.Email = donor.Email;
            donorToUpdate.BloodGroup = donor.BloodGroup;
            donorToUpdate.ContactNo = donor.ContactNo;
            donorToUpdate.Address = donor.Address;

            //_context.Update(donor);
            _dbContext.SaveChanges();
        }

        public void RemoveDonor(Donar donar)
        {
            _dbContext.Remove(donar);
            _dbContext.SaveChanges();
        }

        public List<Donar> GetDonarByBloodGroup(string bloodGroup)
        {
            return _dbContext.Donar.ToList().FindAll(Donar => Donar.BloodGroup == bloodGroup);
        }
    }
}
