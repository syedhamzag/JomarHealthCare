namespace JomarHealthCare.Domain.Entities
{
    public class OnlineTraininglogQuestion
    {
        public int Id { get; set; }
        public string BeforeQuestion { get; set; }
        public string DuringQuestion { get; set; }
        public string AfterQuestion { get; set; }
        public int OnlineTraningId { get; set; }
        public virtual OnlineTraning OnlineTraning { get; set; }
    }
}
