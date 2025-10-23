namespace JomarHealthCare.Domain.Entities
{
    public class CategoryOfStaff
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public Guid? CompanyId { get; set; }

        public virtual ICollection<StaffPersonalInfo> StaffPersonalInfo { get; set; }
    }
}
