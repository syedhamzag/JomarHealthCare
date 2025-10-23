
namespace JomarHealthCare.Domain.Entities
{
    public class StaffCompetenceTest : AuditableEntity,ICompanyEntity
    {
        public StaffCompetenceTest()
        {
            StaffCompetenceTestTask = new HashSet<StaffCompetenceTestTask>();
        }
        public int StaffCompetenceTestId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public string Heading { get; set; }

        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
        public virtual ICollection<StaffCompetenceTestTask> StaffCompetenceTestTask { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
