namespace JomarHealthCare.Domain.Entities
{
    public class ClientLogAudit: AuditableEntity,ICompanyEntity
    {
        public ClientLogAudit()
        {
            OfficerToAct = new HashSet<LogAuditOfficerToAct>();
        }
        public int LogAuditId { get; set; }
        public string Reference { get; set; }
       
        public DateTime Date { get; set; }
        public DateTime NextDueDate { get; set; }
        public string IsCareExpected { get; set; }
        public string IsCareDifference { get; set; }
        public string ProperDocumentation { get; set; }
        public string ImproperDocumentation { get; set; }
        public string Communication { get; set; }
        public string ThinkingServiceUsers { get; set; }
        public string ThinkingStaff { get; set; }
        public string ThinkingStaffStop { get; set; }
        public string Observations { get; set; }
        public string NameOfAuditor { get; set; }
        public string ActionRecommended { get; set; }
        public string ActionTaken { get; set; }
        public string EvidenceOfActionTaken { get; set; }
        public int Status { get; set; }
        public DateTime Deadline { get; set; }
        public string Remarks { get; set; }
        public int RepeatOfIncident { get; set; }
        public string RotCause { get; set; }
        public string LessonLearntAndShared { get; set; }
        public string LogURL { get; set; }
        public string EvidenceFilePath { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
       
        public virtual ICollection<LogAuditOfficerToAct> OfficerToAct { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
