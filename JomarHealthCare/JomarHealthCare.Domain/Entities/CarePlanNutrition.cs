
using System.ComponentModel.DataAnnotations;

namespace JomarHealthCare.Domain.Entities
{
    public class CarePlanNutrition
    {
        public int NutritionId { get; set; }
        public int? FoodStorage { get; set; }
        public string ServingMeal { get; set; }
        public string WhenRestock { get; set; }
        public int? WhoRestock { get; set; }
        public string SpecialDiet { get; set; }
        public string DrinkType { get; set; }
        public string AvoidFood { get; set; }
        public int? ThingsILike { get; set; }
        public int? FoodIntake { get; set; }

        [MaxLength(2048)]
        public string FoodIntakeDetail { get; set; }
        public int? MealPreparation { get; set; }
        public int? EatingDifficulty { get; set; }

        [MaxLength(2048)]
        public string EatingDifficultyDetail { get; set; }
        public string RiskMitigations { get; set; }

        public Guid? ClientId { get; set; }
    }
}
