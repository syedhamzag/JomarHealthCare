namespace JomarHealthCare.Domain.Entities
{
    public class OnlineTraningQuestionOptions
    {
        public int Id { get; set; }
        public string Option { get; set; }
        public int OptionMarks { get; set; }
        public int OnlineTraningQuestionId { get; set; }

        public virtual OnlineTraningQuestion OnlineTraningQuestion { get; set; }
    }
}
