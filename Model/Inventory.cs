using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonationSystem.Model
{
    public class Inventory: IValidatableObject
    {
        [Key]
        public string BloodGroup { get; set; }
        public string Quantity { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (int.TryParse(Quantity, out int quantityValue))
            {
                if (quantityValue < 0)
                {
                    results.Add(new ValidationResult("Quantity cannot be negative.", new[] { nameof(Quantity) }));
                }
            }
            if (!CustomValidationMethod.IsValidBloodGroup(BloodGroup))
            {
                results.Add(new ValidationResult("BloodGroup is not valid.", new[] { nameof(BloodGroup) }));
            }
            return results;
        }


        
    }
}
