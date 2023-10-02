using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BloodDonationSystem.Model
{
    public class Inventory : IValidatableObject
    {
        [Key]
        public string BloodGroup { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            string[] bloodGroupNames = { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" };
            if (!bloodGroupNames.Contains(BloodGroup)){
                result.Add(new ValidationResult("Blood does not Exist.", new[] { nameof(BloodGroup) }));
            }

            return result;
        }

    }
}
