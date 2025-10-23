namespace JomarHealthCare.Domain.Entities
{
    public class IncomeForAllStaff
    {
        public IncomeForAllStaff() {
            IncomeValue = new HashSet<IncomeValue>();
        }
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<IncomeValue> IncomeValue { get; set; }

    }
}
