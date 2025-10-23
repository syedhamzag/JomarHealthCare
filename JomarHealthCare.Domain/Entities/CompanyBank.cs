namespace JomarHealthCare.Domain.Entities
{
    public class CompanyBank: AuditableEntity, ICompanyEntity
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string Title { get; set; }
        public string AccountNo { get; set; }
        public string TransitNo { get; set; }
        public string InstitudionNo { get; set; }
        public string SortCode { get; set; }
        public bool IsUKBank { get; set; }
        public bool IsOperating { get; set; }
        public Guid? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
