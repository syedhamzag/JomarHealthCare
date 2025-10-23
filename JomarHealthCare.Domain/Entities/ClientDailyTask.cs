namespace JomarHealthCare.Domain.Entities
{
    public class ClientDailyTask : AuditableEntity
    {
        public int DailyTaskId { get; set; }
        public string DailyTaskName { get; set; }
        public string HowToPerformTask { get; set; }
        public DateTime Date { get; set; }
        public DateTime AmendmentDate { get; set; }
        public Guid? ClientId { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public virtual Client Client { get; set; }
    }
}
