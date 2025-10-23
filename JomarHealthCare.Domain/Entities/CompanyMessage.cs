namespace JomarHealthCare.Domain.Entities
{
    public class CompanyMessage
    {
        public int Id { get; set; }
        public string CompanysMessage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
