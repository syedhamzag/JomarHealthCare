namespace JomarHealthCare.Domain.Entities
{
    public class PettyCashHeading
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMethod { get; set; }
        public Guid CompanyId { get; set; }
    }
}
