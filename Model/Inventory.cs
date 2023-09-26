using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonationSystem.Model
{
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idForBloodCollection {  get; set; }

        public string? bloodGroup { get; set; }

        public string? Quantity { get;  set; }

        public List<Donar> donarList { get; set; } = new List<Donar>();
    }
}
