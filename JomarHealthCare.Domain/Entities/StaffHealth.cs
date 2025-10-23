
namespace JomarHealthCare.Domain.Entities
{
    public class StaffHealth : AuditableEntity,ICompanyEntity
    {
        public StaffHealth()
        {
            StaffHealthTask = new HashSet<StaffHealthTask>();
        }
        public int StaffHealthId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public string Heading { get; set; }

        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
        public virtual ICollection<StaffHealthTask> StaffHealthTask { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
