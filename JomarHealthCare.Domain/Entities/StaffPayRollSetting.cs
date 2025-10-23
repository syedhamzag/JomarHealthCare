namespace JomarHealthCare.Domain.Entities
{
    public class StaffPayRollSetting
    {
        public int Id { get; set; }
        public decimal FixedAmount { get; set; }
        public int FixedAmountTypeId { get; set; }
        public int StaffRateTypeId { get; set; }
        public int CategoryOfStaffId { get; set; }
        public int TypeOfStaffServiceId { get; set; }
        public int ClassOfStaffId { get; set; }
        public int TeamOfStaffId { get; set; }
        public Guid StaffId { get; set; }
        public decimal? MinHr { get; set; }
        public decimal? MaxHr { get; set; }
    }
}
