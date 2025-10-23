namespace JomarHealthCare.Domain.Entities
{
    public class StaffPerformanceSummary
    {
        public int SummaryId { get; set; }
        public string StartDate { get; set; }
        public string StopDate { get; set; }
        public int? WithoutJob { get; set; }
        public string NoOfPerformance { get; set; }
        public string Feedback { get; set; }
        public string CreatedBy { get; set; }
        public bool IsClientSummary { get; set; }

        public virtual ICollection<StaffPerformance> StaffPerformance { get; set; }
    }
}
