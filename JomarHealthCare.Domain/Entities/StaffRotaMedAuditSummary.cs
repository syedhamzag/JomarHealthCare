namespace JomarHealthCare.Domain.Entities
{
    public class StaffRotaMedAuditSummary
    {
        public int Id { get; set; }
        public string DateOfAudit { get; set; }
        public string NameOfAuditor { get; set; }
        public string AuditPeriodStart { get; set; }
        public string AuditPeriodEnd { get; set; }
        public int? TotalClient { get; set; }
        public int? TotalStaff { get; set; }
        public int? StaffWithConcern { get; set; }
        public int? ClientWithConcern { get; set; }
        public int? NoOfClose { get; set; }
        public int? NoOfOpen { get; set; }
        public int? NoOfPending { get; set; }
        public int? NoOfGPContacted { get; set; }
        public int? NoOfNoticIssueToStaff { get; set; }
        public int? NoOfNoticIssueToClient { get; set; }
        public string AuditClosingStatements { get; set; }
    }
}
