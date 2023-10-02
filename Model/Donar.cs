using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodDonationSystem.Model
{
    public class Donar: IValidatableObject
    {
        [Key]
        public Guid DonarId { get; set; }
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }
        [Required]
        [Phone]
        public string? ContactNo { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }

        //[ForeignKey("BloodGroup")] 
        private string? _bloodGroup;

        [Required]
        public string? BloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value?.ToUpper(); } // Convert to uppercase before setting
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            if (!CustomValidationMethod.IsValidBloodGroup(BloodGroup))
            {
                validationResults.Add(new ValidationResult("BloodGroup is not valid.", new[] { nameof(BloodGroup) }));
            }
            return validationResults;
        }
    }
}
