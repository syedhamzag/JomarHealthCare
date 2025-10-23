namespace JomarHealthCare.Domain.Entities
{
    public class ChatNotification : AuditableEntity,ICompanyEntity
    {
        public int Id { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string Notification { get; set; }
        public DateTime NotifyTime { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
