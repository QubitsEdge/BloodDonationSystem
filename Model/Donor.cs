using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonationSystem.Model
{
    public class Donor
    {
        [Key]
        public Guid DonorID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [BloodGroupAttribute()]
        public string BloodGroup { get; set; }
        [Required]
        [Phone]
        public string ContactNo { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }

    }
}
