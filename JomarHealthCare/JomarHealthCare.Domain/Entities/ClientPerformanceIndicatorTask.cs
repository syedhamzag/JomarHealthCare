namespace JomarHealthCare.Domain.Entities
{
    public class ClientPerformanceIndicatorTask
    {
        public int PerformanceIndicatorTaskId { get; set; }
        public int PerformanceIndicatorId { get; set; }
        public int Title { get; set; }
        public int Score { get; set; }

        public virtual ClientPerformanceIndicator ClientPerformanceIndicator { get; set; }
    }
}
