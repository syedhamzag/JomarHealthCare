namespace JomarHealthCare.Domain.Entities
{
    public class ServiceOfficerToAct
    {
        public int ServiceOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int ServiceId { get; set; }

        public virtual ClientServiceWatch Service { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
