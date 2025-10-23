
namespace JomarHealthCare.Domain.Entities
{
    public class IncidentType
    {
        public int IncidentTypeId { get; set; }
        public string IncidentTypes { get; set; }
        public bool Deleted { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
