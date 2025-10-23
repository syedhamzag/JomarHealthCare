
namespace JomarHealthCare.Domain.Entities
{
    public class ExternalRoleAccess:AuditableEntity
    {
        public ExternalRoleAccess()
        {
            Staff = new HashSet<ExternalRoleAccessStaff>();
            Client = new HashSet<ExternalRoleAccessClient>();
        }
        public int ExternalAccessId { get; set; }
        public virtual ICollection<ExternalRoleAccessStaff> Staff { get; set; }
        public virtual ICollection<ExternalRoleAccessClient> Client { get; set; }
        public int ExternalId { get; set; }
    }
    public class ExternalRoleAccessStaff
    {
        public int ExternalRoleAccessStaffId { get; set; }
        public int ExternalAccessId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public virtual ExternalRoleAccess ExternalRoleAccess { get; set; }
    }
    public class ExternalRoleAccessClient
    {
        public int ExternalRoleAccessClientId { get; set; }
        public int ExternalAccessId { get; set; }
        public Guid ClientId { get; set; }
        public virtual ExternalRoleAccess ExternalRoleAccess { get; set; }
    }
}
