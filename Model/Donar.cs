namespace BloodDonationSystem.Model
{
    public class Donar
    {
        public Guid DonarId { get; set; } 
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? bloodGroup { get; set; }
        public string? contactNo { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
