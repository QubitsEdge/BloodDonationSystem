using BloodDonationSystem.Model;

namespace BloodDonationSystem.Repository
{
    public interface IDonorRepository
    {
        Donor GetByGuid(Guid id);
        void AddDonor(Donor donor);

        List<Donor> GetAll();

        void RemoveDonor(Donor donor);

    }
}
