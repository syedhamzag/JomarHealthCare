namespace JomarHealthCare.Domain.Entities
{
    public class LogAuditSummary
    {
        public int Id { get; set; }
        public string DateOfAudit { get; set; }
        public string NameOfAuditor { get; set; }
        public string AuditPeriodStart { get; set; }
        public string AuditPeriodEnd { get; set; }
        public int? TotalClient { get; set; }
        public int? TotalNoOfHappyClient { get; set; }
        public int? TotalObjectMet { get; set; }
        public int? TotalObjectNotMet { get; set; }
        public int? TotalStaff { get; set; }
        public int? StaffWithConcern { get; set; }
        public int? ClientWithConcern { get; set; }
        public int? NoOfClose { get; set; }
        public int? NoOfOpen { get; set; }
        public int? NoOfPending { get; set; }
        public int? NoOfNoticIssueToStaff { get; set; }
        public int? NoOfNoticIssueToClient { get; set; }
        public string selectedClient { get; set; }
        public string selectedStaff { get; set; }
        public string CreatedBy { get; set; }
        public string AuditClosingStatements { get; set; }
        public DateTime AuditDate { get; set; }
        public DateTime NextAuditDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
