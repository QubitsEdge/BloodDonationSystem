using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonationSystem.Model
{
    public class Donar
    {
        [Key]
        public Guid DonarId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        //[ForeignKey("BloodGroup")] 
        public string? BloodGroup { get; set; }

        // Navigation property for the Inventory to which this Donar belongs
        //public Inventory Inventory { get; set; }
    }
}
