
namespace JomarHealthCare.Domain.Entities
{
    public class StaffTax : AuditableEntity,ICompanyEntity
    {
        public int StaffTaxId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public decimal Tax { get; set; }
        public decimal NI { get; set; }
        public string Remarks { get; set; }

        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
