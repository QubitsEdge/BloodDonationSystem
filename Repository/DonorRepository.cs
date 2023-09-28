using BloodDonationSystem.Model;

namespace BloodDonationSystem.Repository
{
    public class DonorRepository : IDonorRepository
    {
        private readonly AppDbContext _context;
        public DonorRepository(AppDbContext context) { 
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }    


        public void AddDonor(Donor donor)
        {
            _context.Donors.Add(donor);
            _context.SaveChanges();
        }

        public Donor GetByGuid(Guid id)
        {
            return _context.Donors.ToList().FirstOrDefault(donor => donor.DonorID == id) ?? new Donor();
        }

        public List<Donor> GetAllDonors()
        {
            return _context.Donors.ToList();
        }

        public void UpdateDonor(Donor donor)
        {

            Donor donorToUpdate = GetByGuid(donor.DonorID);
            donorToUpdate.FirstName = donor.FirstName;
            donorToUpdate.LastName = donor.LastName;
            donorToUpdate.Email = donor.Email;
            donorToUpdate.BloodGroup = donor.BloodGroup;
            donorToUpdate.ContactNo = donor.ContactNo;
            donorToUpdate.Address = donor.Address;

            
            _context.SaveChanges();
        }

        public void RemoveDonor(Donor donor)
        {
            _context.Remove(donor); 
            _context.SaveChanges();
        }

        public List<Donor> GetDonorsByBloodGroup(string bloodGroup)
        {
            return _context.Donors.ToList().FindAll(donor => donor.BloodGroup == bloodGroup);
        }
    }
}
