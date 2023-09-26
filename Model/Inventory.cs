using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonationSystem.Model
{
    public class Inventory
    {
        //        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //        public int IdForBloodCollection { get; set; }
        [Key]
        public string BloodGroup { get; set; }
        public string Quantity { get; set; }

        public List<Donar> DonarList { get; set; } = new List<Donar>();
    }
}
