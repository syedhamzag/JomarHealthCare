
namespace JomarHealthCare.Domain.Entities
{
    public class StaffTeamLeadTasks : AuditableEntity,ICompanyEntity
    {
        public int TeamLeadTaskId { get; set; }
        public int TeamLeadId { get; set; }
        public int Title { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }

        public virtual StaffTeamLead StaffTeamLead { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
