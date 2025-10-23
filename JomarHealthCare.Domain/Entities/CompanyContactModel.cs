using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
   public class CompanyContactModel
    {
        public int CompanyContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public virtual CompanyModel Company { get; set; }
    }
}
