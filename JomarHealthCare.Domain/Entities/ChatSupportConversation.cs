namespace JomarHealthCare.Domain.Entities
{
    public class ChatSupportConversation : AuditableEntity,ICompanyEntity
    {
        public int Id { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public int ChatSupportId { get; set; }
        public string Message { get; set; }
        public string FilePath { get; set; }
        public string SessionId { get; set; }
        public string OpenTokToken { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsByStaff { get; set; }
        public virtual ChatSupport ChatSupport { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
