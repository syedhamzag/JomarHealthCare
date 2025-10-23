namespace JomarHealthCare.Domain.Entities
{
    public class PlannedIncome
    {
        public int Id { get; set; }
        public Guid StaffId { get; set; }
        public int IncomeId { get; set; }
        public float GrossAmount { get; set; }
        public int? AmountToAdd { get; set; }
        public string PercentageOfGross { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
