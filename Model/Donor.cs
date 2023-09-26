using System.ComponentModel.DataAnnotations;

namespace BloodDonationSystem.Model
{
    public class Donor
    {
        [Key]
        public Guid DonorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BloodGroup { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }
}
