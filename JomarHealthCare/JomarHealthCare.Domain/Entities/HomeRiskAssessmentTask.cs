
namespace JomarHealthCare.Domain.Entities
{
    public class HomeRiskAssessmentTask : AuditableEntity
    {
        public HomeRiskAssessmentTask()
        {
        }
        public int HomeRiskAssessmentTaskId { get; set; }
        public int HomeRiskAssessmentId { get; set; }
        public int Title { get; set; }
        public int Answer { get; set; }
        public string Comment { get; set; }

        public virtual HomeRiskAssessment HomeRiskAssessment { get; set; }
    }
}
