using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BloodDonationSystem.Model
{
    public class Inventory
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int BloodID { get; set; }

        [Key]
        public string BloodGroup { get; set; }
        public int Quantity { get; set; }
        public List<Donor> Donor { get; set; } = new List<Donor>();
    }
}
