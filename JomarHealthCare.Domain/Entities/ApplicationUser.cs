using Microsoft.AspNetCore.Identity;

namespace JomarHealthCare.Domain.Entities
{
    public class ApplicationUser : IdentityUser, ICompanyEntity
    {
        public ApplicationUser()
        {
            StaffMedRota = new HashSet<StaffMedRota>();
            OfficeAttendance = new HashSet<OfficeAttendance>();
            ShiftBooking = new HashSet<ShiftBooking>();
            StaffWorkTeam = new HashSet<StaffWorkTeam>();
            OfficeLocation = new HashSet<OfficeLocation>();
        }
        public virtual ICollection<StaffMedRota> StaffMedRota { get; set; }
        public virtual ICollection<OfficeAttendance> OfficeAttendance { get; set; }
        public virtual ICollection<ShiftBooking> ShiftBooking { get; set; }
        public virtual ICollection<StaffWorkTeam> StaffWorkTeam { get; set; }
        public virtual ICollection<OfficeLocation> OfficeLocation { get; set; }
        public Guid? StaffId { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
