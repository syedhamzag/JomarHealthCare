namespace JomarHealthCare.Application.DataModels.Client.Nutrition;

public class ClientNutritionDataModel
{
    public int NutritionId { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public string MealSpecialNote { get; set; }
    public string ShoppingSpecialNote { get; set; }
    public string CleaningSpecialNote { get; set; }
    public List<ClientShoppingDataModel> ClientShopping { get; set; }
    public List<ClientCleaningDataModel> ClientCleaning { get; set; }
    public List<ClientMealDaysDataModel> ClientMealDays { get; set; }
    public Guid? ClientId { get; set; }
    public Guid? StaffId { get; set; }
}

public class ClientShoppingDataModel
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
}

public class ClientCleaningDataModel
{
    public int CleaningId { get; set; }
    public int NutritionId { get; set; }
    public int? AreasAndItems { get; set; }
    public string Details { get; set; }
    public string SafetyHazard { get; set; }
    public string LocationOfItem { get; set; }
    public string DescOfItem { get; set; }
    public DateTime? MinuteAlloted { get; set; }
    public string Disposal { get; set; }
    public int? WhereToGet { get; set; }
    public string WhereToKeep { get; set; }
    public string SeeVideo { get; set; }
    public string Image { get; set; }
    public string DayOfCleaning { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public Guid? StaffId { get; set; }
}

public class ClientMealDaysDataModel
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
}