using BloodDonationSystem.Model;

namespace BloodDonationSystem.Repository
{
    public interface IDonarRepository
    {
        Donar GetByGuid(Guid id);
        void AddDonor(Donar donor);

        List<Donar> GetAll();

        void RemoveDonor(Donar donor);

        List<Donar> GetDonarByBloodGroup(string bloodGroup);    

    }
}
