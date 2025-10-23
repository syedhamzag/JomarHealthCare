namespace JomarHealthCare.Domain.Entities
{
  public  class BloodPressureStaffName
    {
        public int BloodPressureStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int BloodPressureId { get; set; }

        public virtual ClientBloodPressure BloodPressure { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
