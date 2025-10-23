namespace JomarHealthCare.Domain.Entities
{
    public class OnlineLogQuestionResults
    {
        public int Id { get; set; }
        public int OnlineTrainingId { get; set; }
        public int LogQuestionId { get; set; }
        public string BeforeAnswer { get; set; }
        public string DuringAnswer { get; set; }
        public string AfterAnswer { get; set; }
        public decimal? ObtainMark { get; set; }
        public int? staffId { get; set; }
        public int? BundleId { get; set; }
    }
}
