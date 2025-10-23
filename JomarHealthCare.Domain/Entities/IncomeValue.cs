namespace JomarHealthCare.Domain.Entities
{
    public class IncomeValue
    {
        public int Id { get; set; }
        public int IncomeForAllStaffId { get; set; }
        public int IncomeType { get; set; }
        public int IncomeAmount { get; set; }
        public virtual IncomeForAllStaff IncomeForAllStaff { get; set; }


    }
}
