namespace BloodDonationSystem.Model
{
    public class CustomValidationMethod
    {
        public static bool IsValidBloodGroup(string bloodGroup)
        {
            var validBloodGroups = new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
            return !string.IsNullOrWhiteSpace(bloodGroup) && validBloodGroups.Contains(bloodGroup.ToUpper());

        }
    }
}
