using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BloodDonationSystem.Model
{
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BloodID { get; set; }
        public string BloodGroup { get; set; }
        public int Quantity { get; set; }
        public List<Donor> Donors { get; set; } = new List<Donor>();
    }
}
