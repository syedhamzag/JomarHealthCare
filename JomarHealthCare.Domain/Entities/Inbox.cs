namespace JomarHealthCare.Domain.Entities
{
    public class Inbox : AuditableEntity,ICompanyEntity
    {

        public int Id { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Conversation> Conversation { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
