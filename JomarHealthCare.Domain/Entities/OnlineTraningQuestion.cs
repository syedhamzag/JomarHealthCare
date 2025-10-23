namespace JomarHealthCare.Domain.Entities
{
    public class OnlineTraningQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int QuestionMarks { get; set; }
        public int OnlineTraningId { get; set; }

        public virtual OnlineTraning OnlineTraning { get; set; }
        public virtual ICollection<OnlineTraningQuestionOptions> OnlineTraningQuestionOptions { get; set; }
    }
}
