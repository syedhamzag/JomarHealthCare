
namespace JomarHealthCare.Domain.Entities
{
    public class InterestAndObjective : AuditableEntity
    {

        public InterestAndObjective()
        {
            PersonalityTest = new HashSet<PersonalityTest>();
        }

        public int GoalId { get; set; }       
        public string CareGoal { get; set; }
        public string Brief { get; set; }
        public int? InterestId { get; set; }
        public int? LeisureActivity { get; set; }
        public int? InformalActivity { get; set; }
        public int? MaintainContact { get; set; }
        public int? CommunityActivity { get; set; }
        public int? EventAwarness { get; set; }
        public int? GoalAndObjective { get; set; }
        public virtual ICollection<PersonalityTest> PersonalityTest { get; set; }
        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
