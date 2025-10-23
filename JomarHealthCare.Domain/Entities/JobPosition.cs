namespace JomarHealthCare.Domain.Entities
{
    public class JobPosition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid? CompanyId { get; set; }

        public virtual ICollection<StaffPersonalInfo> StaffPersonalInfo { get; set; }
        public virtual ICollection<StaffPerformanceHeading> StaffPerformanceHeading { get; set; }
    }
}
