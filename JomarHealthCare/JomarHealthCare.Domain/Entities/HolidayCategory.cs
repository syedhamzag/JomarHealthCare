namespace JomarHealthCare.Domain.Entities
{
    public class HolidayCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NoOfDays { get; set; }
        public string CompanyId { get; set; }
    }
}
