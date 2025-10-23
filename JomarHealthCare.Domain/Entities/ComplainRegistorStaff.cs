namespace JomarHealthCare.Domain.Entities
{
    public class ComplainRegistorStaff
    {
        public int Id { get; set; }
        public int ComplainRegistorId { get; set; }
        public Guid StaffId { get; set; }
        public string StaffResponse { get; set; }
        public virtual StaffPersonalInfo Staff { get; set; }
        public virtual ComplainRegistor ComplainRegistor { get; set; }
    }
}
