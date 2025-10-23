namespace JomarHealthCare.Domain.Entities
{
    public class PersonalityTest
    {
        public int TestId { get; set; }
        public int GoalId { get; set; }
        public int Question { get; set; }
        public int Answer { get; set; }
        public virtual InterestAndObjective InterestAndObjective { get; set; }
    }
}
