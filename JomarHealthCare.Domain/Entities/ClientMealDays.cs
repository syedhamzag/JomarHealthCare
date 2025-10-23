namespace JomarHealthCare.Domain.Entities
{
    public class ClientMealDays
    {

        public int ClientMealId { get; set; }
        public int NutritionId { get; set; }
        public int? MealDayofWeekId { get; set; }
        public int? ClientMealTypeId { get; set; }
        public int? TypeId { get; set; }
        public string MealDetail { get; set; }
        public string HowToPrepare { get; set; }
        public string SeeVideo { get; set; }
        public string Picture { get; set; }

        public virtual ClientNutrition ClientNutrition { get; set; }
    }
}
