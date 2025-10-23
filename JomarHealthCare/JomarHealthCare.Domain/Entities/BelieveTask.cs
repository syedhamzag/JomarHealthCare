namespace JomarHealthCare.Domain.Entities
{
    public class BelieveTask
    {
        public int BelieveTaskId { get; set; }
        public int BestId { get; set; }
       
        public int ReasonableBelieve { get; set; }
        public virtual BestInterestAssessment BestInterestAssessment { get; set; }
    }
}
