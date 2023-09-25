using System.ComponentModel.DataAnnotations;

namespace BloodDonationSystem.Model
{
    public class Inventory
    {
        [Key]
        
        public int idForBloodCollection {  get; set; }

        public string? bloodGroup { get; set; }

        public string? Quantity { get;  set; }

        public List<Donar> donarList { get; set; } = new List<Donar>();
    }
}
