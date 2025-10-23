
namespace JomarHealthCare.Domain.Entities
{
    public class StaffCompetenceTestTask : AuditableEntity,ICompanyEntity
    {
        public StaffCompetenceTestTask()
        {
        }

        public int StaffCompetenceTestTaskId { get; set; }
        public int StaffCompetenceTestId { get; set; }
        public int Title { get; set; }
        public int Answer { get; set; }
        public string Comment { get; set; }
        public int Point { get; set; }
        public int Score { get; set; }

        public virtual StaffCompetenceTest StaffCompetenceTest { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
