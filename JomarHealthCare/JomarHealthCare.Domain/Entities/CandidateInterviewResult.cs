namespace JomarHealthCare.Domain.Entities
{
    public class CandidateInterviewResult
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public int Point { get; set; }
        public int CandidateInterviewId { get; set; }
    }
}
