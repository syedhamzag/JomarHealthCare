namespace JomarHealthCare.Domain.Entities
{
    public class ClientCleaning
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
        public virtual ClientNutrition ClientNutrition { get; set; }
    }
}
