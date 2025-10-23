namespace JomarHealthCare.Domain.Entities
{
    public class ServiceStaffName
    {
        public int ServiceStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int ServiceId { get; set; }

        public virtual ClientServiceWatch Service { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
