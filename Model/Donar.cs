using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonationSystem.Model
{
    public class Donar
    {
        public Guid DonarId { get; set; } 
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

       [ForeignKey("Inventory.BloodGroup")]
        public string? BloodGroup { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        public Inventory Inventory { get; set; }
    }
}
