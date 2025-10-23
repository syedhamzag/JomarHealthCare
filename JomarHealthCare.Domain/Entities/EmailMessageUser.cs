namespace JomarHealthCare.Domain.Entities
{
    public class EmailMessageUser
    {
        public int Id { get; set; }
        public int EmailMessageId { get; set; }
        public int? StaffId { get; set; }
        public string IncludeCC { get; set; }

        public virtual EmailMessage EmailMessage { get; set; }
    }
}
