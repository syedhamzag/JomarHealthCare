namespace JomarHealthCare.Domain.Entities
{
    public class CareIssuesTask
    {
        public int CareIssuesTaskId { get; set; }
        public int BestId { get; set; }

        public int Issues { get; set; }

        public virtual BestInterestAssessment BestInterestAssessment { get; set; }
    }

}
