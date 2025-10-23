namespace JomarHealthCare.Domain.Entities
{
    public class ClientNutrition
    {
        public int NutritionId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string MealSpecialNote { get; set; }
        public string ShoppingSpecialNote { get; set; }
        public string CleaningSpecialNote { get; set; }
        public virtual ICollection<ClientShopping> ClientShopping { get; set; }
        public virtual ICollection<ClientCleaning> ClientCleaning { get; set; }
        public virtual ICollection<ClientMealDays> ClientMealDays { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? StaffId { get; set; }
    }
}
