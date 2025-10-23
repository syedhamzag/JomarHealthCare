namespace JomarHealthCare.Domain.Entities
{
    public class EmailMessage
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int? Category { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
        public string CompanyId { get; set; }
        public virtual ICollection<EmailMessageUser> EmailMessageUser { get; set; }
    }
}
