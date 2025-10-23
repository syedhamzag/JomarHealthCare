namespace JomarHealthCare.Domain.Entities
{
   public class OfficeLocation
    {
        public int OfficeLocationId { get; set; }
        public string UniqueId { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ContactPersonFullName { get; set; }
        public string ContactPersonEmail { get; set; }
        public string ContactPersonPhoneNumber { get; set; }
        public string CreatedBy { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<StaffOfficeLocation> StaffOfficeLocation { get; set; } = new HashSet<StaffOfficeLocation>();
    }
}
