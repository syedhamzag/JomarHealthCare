namespace JomarHealthCare.Domain.Entities
{
    public class HealthTask2
    {
        public int HealthTask2Id { get; set; }
        public int BestId { get; set; }
        public int Heading2Id { get; set; }
        public int Title { get; set; }
        public int Answer { get; set; }
        public string Remark { get; set; }
        public virtual BestInterestAssessment BestInterestAssessment { get; set; }

    }
}
