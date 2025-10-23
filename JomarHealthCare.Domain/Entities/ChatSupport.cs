namespace JomarHealthCare.Domain.Entities
{
    public class ChatSupport : AuditableEntity,ICompanyEntity
    {
        public int Id { get; set; }
        public string FromUserId { get; set; }
        public string ChatType { get; set; }
        //public string ToUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<ChatSupportConversation> ChatSupportConversation { get; set; }
        public Guid? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
