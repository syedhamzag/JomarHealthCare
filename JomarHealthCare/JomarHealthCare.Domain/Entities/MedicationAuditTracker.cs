using System.ComponentModel.DataAnnotations;

namespace JomarHealthCare.Domain.Entities
{
    public class MedicationAuditTracker
    {
        public int Id { get; set; }
        public string AuditRemarks { get; set; }
        public string ActionRecommendation { get; set; }
        public bool ContactEstablishedWithGP { get; set; }
        public string StateDisuccGP { get; set; }
        public string EvidenceOfActionTaken { get; set; }
        public string Status { get; set; }
        [Required]
        public string NameOfAuditor { get; set; }
        public DateTime DateOfAudit { get; set; }
        public bool EmailAuditToClient { get; set; }
        public bool EmailAuditToStaff { get; set; }
        public bool ConcernWithStaff { get; set; }
        public bool ConcertWithClient { get; set; }
        public int StaffRotaId { get; set; }
    }
}
