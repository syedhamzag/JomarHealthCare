using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class CareReview : AuditableEntity, ICompanyEntity
    {
        [Key]
        public Guid CareReviewId { get; set; }
        public string Note { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Action { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
        [ForeignKey("Company")]
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
