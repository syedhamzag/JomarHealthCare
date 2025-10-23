
namespace JomarHealthCare.Domain.Entities
{
    public class HomeRiskAssessment : AuditableEntity
    {
        public HomeRiskAssessment()
        {
            HomeRiskAssessmentTask = new HashSet<HomeRiskAssessmentTask>();
        }
        public int HomeRiskAssessmentId { get; set; }

        public int? HeadingId { get; set; }

        public virtual ICollection<HomeRiskAssessmentTask> HomeRiskAssessmentTask { get; set; }
        public Guid? ClientId { get; set; }
    }
}
