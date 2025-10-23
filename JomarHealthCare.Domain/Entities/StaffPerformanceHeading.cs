namespace JomarHealthCare.Domain.Entities
{
    public class StaffPerformanceHeading
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? JobPositionId { get; set; }
        public string CreatedBy { get; set; }
        public bool IsClientHeading { get; set; }
        public virtual JobPosition JobPosition { get; set; }
    }
}
