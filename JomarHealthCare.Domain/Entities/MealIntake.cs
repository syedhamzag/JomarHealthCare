namespace JomarHealthCare.Domain.Entities
{
    public class MealIntake
    {
        public int MealIntakeId { get; set; }
        public int? StaffRotaPeriodId { get; set; }
        public string Name { get; set; }
        public int? Dose { get; set; }
    }
}
