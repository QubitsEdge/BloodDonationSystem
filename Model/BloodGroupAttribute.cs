using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BloodDonationSystem.Model
{
    public class BloodGroupAttribute : ValidationAttribute
    {
        private readonly string[] _bloodGroups;

        public BloodGroupAttribute()
        {
            string[] bloodGroupNames = { "O+", "O-","A+","A-","B+","B-","AB+","AB-"};
            _bloodGroups = bloodGroupNames;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            bool isExist = false;
            var donor = (Donor)validationContext.ObjectInstance;

            foreach(string group in _bloodGroups)
            {
                if(donor.BloodGroup == group)
                {
                    isExist = true;
                }
            }
            if (isExist)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Blood group does not Exist.");
            }

        }
    }
}
