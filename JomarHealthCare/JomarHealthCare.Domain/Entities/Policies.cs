namespace JomarHealthCare.Domain.Entities
{
    public class Policies : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ref { get; set; }
        public string PolicyOwner { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? LastReview { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public PolicyType PolicyType { get; set; }
    }
}
