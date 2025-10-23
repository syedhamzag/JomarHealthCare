namespace JomarHealthCare.Domain.Entities
{
    public class StaffOfficeLocation
    {
        public int Id { get; set; }

        public int Location { get;set; }
        public virtual OfficeLocation OfficeLocation { get; set; }
        public Guid StaffId { get; set; }
        // public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
