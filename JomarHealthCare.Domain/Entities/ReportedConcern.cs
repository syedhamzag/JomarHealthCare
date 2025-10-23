
namespace JomarHealthCare.Domain.Entities
{
    public class ReportedConcern
    {
        public int ReportedConcernId { get; set; }
        public string ReportedConcernType { get; set; }
        public bool Deleted { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
