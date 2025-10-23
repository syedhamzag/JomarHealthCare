namespace JomarHealthCare.Domain.Entities
{
    public class EquipmentAssessment: AuditableEntity
    {
        public int Id { get; set; }
       
        public string EquipmentName { get; set; }
        public string EquipmentLocation { get; set; }
        public string EquipmentStatus { get; set; }
        public string Url { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Training { get; set; }
        public string HowToUse { get; set; }
        public string RiskOfClient { get; set; }
        public string RiskOfStaff { get; set; }
        public string Environment { get; set; }
        public string RiskControl { get; set; }
        public string Escalation { get; set; }
        public string Attachment { get; set; }
        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
