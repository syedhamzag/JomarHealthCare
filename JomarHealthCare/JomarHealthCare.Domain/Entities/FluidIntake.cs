namespace JomarHealthCare.Domain.Entities
{
    public class FluidIntake
    {
        public int FluidIntakeId { get; set; }
        public int? StaffRotaPeriodId { get; set; }
        public string Name { get; set; }
        public int? Dose { get; set; }
    }
}
