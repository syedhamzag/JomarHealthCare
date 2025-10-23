
namespace JomarHealthCare.Domain.Entities
{
    public class StaffAlertCountMatrix : AuditableEntity,ICompanyEntity
    {
        public int Id { get; set; }
        public int StaffAlertId { get; set; }
        public int Missed { get; set; }
        public int Expired { get; set; }
        public int AboutToExpired { get; set; }
        public int TotalCouts { get; set; }
        public StaffAlert StaffAlert { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
