namespace JomarHealthCare.Domain.Entities
{
    public class ChatSupportAssignedStaff : AuditableEntity,ICompanyEntity
    {
        public int Id { get; set; }
        public int ToUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ChatSupportId { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
