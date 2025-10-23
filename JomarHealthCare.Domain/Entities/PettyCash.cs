namespace JomarHealthCare.Domain.Entities
{
    public class PettyCash
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public DateTime? Date { get; set; }
        public Guid StaffId { get; set; }
        public int? MethodId { get; set; }
        public decimal Amount { get; set; }
        public Guid CompanyId { get; set; }
        public virtual ICollection<PettyCashUsage> PettyCashUsage { get; set; }
    }
}
