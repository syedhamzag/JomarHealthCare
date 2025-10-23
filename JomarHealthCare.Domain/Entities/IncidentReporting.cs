
namespace JomarHealthCare.Domain.Entities
{
    public class IncidentReporting : AuditableEntity, ICompanyEntity
    {
        public int IncidentReportingId { get; set; }
        public int? ReportingStaffId { get; set; }
       
        public int StaffInvolvedId { get; set; }
        public int IncidentTypeId { get; set; }
        public string IncidentDetails { get; set; }
        public string ActionTaken { get; set; }
        public string Witness { get; set; }
        public string Attachment { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
       
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
