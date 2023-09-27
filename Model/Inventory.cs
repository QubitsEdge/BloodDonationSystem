using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonationSystem.Model
{
    public class Inventory
    {
        [Key]
        public string BloodGroup { get; set; }
        public string Quantity { get; set; }

        // Navigation property for the list of Donars associated with this Inventory
        //public List<Donar> DonarList { get; set; } = new List<Donar>();
    }
}
