namespace JomarHealthCare.Domain.Entities
{
    public class StaffIncidentReporting : AuditableEntity, ICompanyEntity
    {
        public int StaffIncidentReportingId { get; set; }
        public int? ReportingStaffId { get; set; }
       
        public int StaffInvolvedId { get; set; }
        /// <summary>
        /// From Base Record
        /// </summary>
        public string IncidentDetails { get; set; }
        public string ActionTaken { get; set; }
        public string Witness { get; set; }
        public string Attachment { get; set; }
        /// <summary>
        /// ApplicationUserId
        /// </summary>
        public string LoggedById { get; set; }

        public string IncidentType { get; set; }
        public string Status { get; set; }
        public DateTimeOffset LoggedDate { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
