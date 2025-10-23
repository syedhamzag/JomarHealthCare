namespace JomarHealthCare.Domain.Entities
{
    public class DefaultStaffSupport
    {
        public int Id { get; set; }
        public Guid StaffId { get; set; }
        public string SupportType { get; set; }
    }
}
