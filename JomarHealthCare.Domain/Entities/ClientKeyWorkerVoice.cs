namespace JomarHealthCare.Domain.Entities
{
    public class ClientKeyWorkerVoice:AuditableEntity,ICompanyEntity
    {
        public int Id { get; set; }
        public int KeyWorkerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
       
        public Guid StaffId { get; set; }
       
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
