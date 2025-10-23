
namespace JomarHealthCare.Domain.Entities
{
    public class CuidiBuddy: AuditableEntity,ICompanyEntity
    {
        public int Id { get; set; }
       
        public int CuidiBuddyId { get; set; }
       
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
