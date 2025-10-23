namespace JomarHealthCare.Domain.Entities
{
    public class Chat : AuditableEntity,ICompanyEntity
    {
        public int ChatId { get; set; }
        public int ReceiverId { get; set; }
        public int SenderId { get; set; }
        public string Message { get; set; }
        public DateTime Dated { get; set; }
        public string Type { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
