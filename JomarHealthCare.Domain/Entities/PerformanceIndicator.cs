namespace JomarHealthCare.Domain.Entities
{
    public class PerformanceIndicator : AuditableEntity,ICompanyEntity
    {
        public PerformanceIndicator()
        {
            PerformanceIndicatorTask = new HashSet<PerformanceIndicatorTask>();
        }
        public int PerformanceIndicatorId { get; set; }
        public string Heading { get; set; }

        public DateTime Date { get; set; }

        public DateTime DueDate { get; set; }

        public int Rating { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<PerformanceIndicatorTask> PerformanceIndicatorTask { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
