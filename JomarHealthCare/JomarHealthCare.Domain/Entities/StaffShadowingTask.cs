
namespace JomarHealthCare.Domain.Entities
{
    public class StaffShadowingTask : AuditableEntity,ICompanyEntity
    {
        public int StaffShadowingTaskId { get; set; }
        public int StaffShadowingId { get; set; }
        public int Title { get; set; }
        public int Answer { get; set; }
        public string Comment { get; set; }
        public int Point { get; set; }
        public int Score { get; set; }

        public virtual StaffShadowing StaffShadowing { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
