<<<<<<< HEAD
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
>>>>>>> Ahmad

namespace BloodDonationSystem.Model
{
    public class Inventory
    {
<<<<<<< HEAD
        [Key]
        public string BloodGroup { get; set; }
        public string Quantity { get; set; }

        // Navigation property for the list of Donars associated with this Inventory
        public List<Donar> DonarList { get; set; } = new List<Donar>();
=======

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int BloodID { get; set; }

        [Key]
        public string BloodGroup { get; set; }
        public int Quantity { get; set; }
        public List<Donor> Donor { get; set; } = new List<Donor>();
>>>>>>> Ahmad
    }
}
