namespace JomarHealthCare.Domain.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
