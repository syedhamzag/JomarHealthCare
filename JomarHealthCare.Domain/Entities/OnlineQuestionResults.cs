namespace JomarHealthCare.Domain.Entities
{
    public class OnlineQuestionResults
    {
        public int Id { get; set; }
        public int OnlineTrainingId { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }
        public int? staffId { get; set; }
        public int? BundleResultId { get; set; }
    }
}
