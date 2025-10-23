namespace JomarHealthCare.Domain.Entities
{
  public  class BloodPressurePhysician
    {
        public int BloodPressurePhysicianId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int BloodPressureId { get; set; }

        public virtual ClientBloodPressure BloodPressure { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
