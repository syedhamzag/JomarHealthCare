
namespace JomarHealthCare.Domain.Entities
{
  public  class StaffRotaDynamicAddition: AuditableEntity,ICompanyEntity
    {
        public int StaffRotaDynamicAdditionId { get; set; }
        public string ItemName { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
