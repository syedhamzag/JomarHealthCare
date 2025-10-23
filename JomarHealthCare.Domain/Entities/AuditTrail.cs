using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class AuditTrail : AuditableEntity, ICompanyEntity
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public DateTime Duration { get; set; }
        
       
       
        [ForeignKey("Company")]
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
