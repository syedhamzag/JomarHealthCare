namespace JomarHealthCare.Domain.Entities
{
    public class ClientShopping
    {
        public int ShoppingId { get; set; }
        public int NutritionId { get; set; }
        public string MeansOfPurchase { get; set; }
        public string LocationOfPurchase { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public string Image { get; set; }
        public string DayOfShopping { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid? StaffId { get; set; }
        public virtual ClientNutrition ClientNutrition { get; set; }
    }
}
