namespace JomarHealthCare.Domain.Entities
{
    public class PlannedDeduction
    {
        public int Id { get; set; }
        public Guid StaffId { get; set; } 
        public int DeductionId { get; set; } 
        public float GrossAmount { get; set; } 
        public int? AmountToDeduct { get; set; } 
        public string PercentageOfGross { get; set; } 
        public DateTime FromDate { get; set; } 
        public DateTime ToDate { get; set; } 
    }
}
