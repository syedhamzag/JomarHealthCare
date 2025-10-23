namespace JomarHealthCare.Domain.Entities
{
    public class HospitalEntryStaffInvolved
    {
        public int HospitalEntryStaffInvolvedId { get; set; }
        public int HospitalEntryId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public virtual HospitalEntry HospitalEntry { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
