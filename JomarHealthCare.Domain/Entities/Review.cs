namespace JomarHealthCare.Domain.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public DateTime? CP_PreDate { get; set; }
        public DateTime? CP_ReviewDate { get; set; }
        public string CarePlanStatus { get; set; }
        public DateTime? RA_PreDate { get; set; }
        public DateTime? RA_ReviewDate { get; set; }
        public string RisAssistmentStatus { get; set; }
        public Guid ClientId { get; set; }
    }
}
