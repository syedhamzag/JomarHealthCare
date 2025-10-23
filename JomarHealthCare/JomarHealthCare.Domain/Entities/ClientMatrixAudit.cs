namespace JomarHealthCare.Domain.Entities
{
    public class ClientMatrixAudit:AuditableEntity,ICompanyEntity
    {
        public int Id { get; set; }
       
        public string AuditorName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string closingStatement { get; set; }
        public bool IsMedAudit { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
