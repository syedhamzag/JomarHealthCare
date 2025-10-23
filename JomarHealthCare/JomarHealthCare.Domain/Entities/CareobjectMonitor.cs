namespace JomarHealthCare.Domain.Entities
{
    public class CareobjectMonitor : AuditableEntity,ICompanyEntity
    {
        public int Id { get; set; }
       
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? Day { get; set; }
        public DateTime? DateOfCare { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
