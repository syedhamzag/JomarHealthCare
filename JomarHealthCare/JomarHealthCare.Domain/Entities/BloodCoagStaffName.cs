namespace JomarHealthCare.Domain.Entities
{
  public  class BloodCoagStaffName
    {
        public int BloodCoagStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int BloodRecordId { get; set; }

        public virtual ClientBloodCoagulationRecord BloodCoagulation { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
