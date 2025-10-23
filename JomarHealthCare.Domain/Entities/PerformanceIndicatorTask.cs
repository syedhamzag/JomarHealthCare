
namespace JomarHealthCare.Domain.Entities
{
    public class PerformanceIndicatorTask : AuditableEntity,ICompanyEntity
    {
        public PerformanceIndicatorTask()
        {
        }
        public int PerformanceIndicatorTaskId { get; set; }
        public int PerformanceIndicatorId { get; set; }
        public int Title { get; set; }
        public int Score { get; set; }

        public virtual PerformanceIndicator PerformanceIndicator { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
