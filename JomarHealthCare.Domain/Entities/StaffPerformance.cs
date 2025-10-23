
namespace JomarHealthCare.Domain.Entities
{
    public class StaffPerformance : AuditableEntity,ICompanyEntity
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public string Data { get; set; }
        public int? TotalObtain { get; set; }
        public int? Expectation { get; set; }
        public string Rating { get; set; }
        public string CreatedBy { get; set; }
        public string Remarks { get; set; }
        public int? PositionId { get; set; }
        public int PerformanceSummaryId { get; set; }
        public int? ClientId { get; set; }
        public virtual StaffPerformanceSummary PerformanceSummary { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
