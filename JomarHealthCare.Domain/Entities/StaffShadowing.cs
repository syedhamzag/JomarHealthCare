
namespace JomarHealthCare.Domain.Entities
{
    public class StaffShadowing : AuditableEntity,ICompanyEntity
    {
        public StaffShadowing()
        {
            StaffShadowingTask = new HashSet<StaffShadowingTask>();
        }
        public int StaffShadowingId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public string Heading { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
        public virtual ICollection<StaffShadowingTask> StaffShadowingTask { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
