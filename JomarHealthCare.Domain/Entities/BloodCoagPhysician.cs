namespace JomarHealthCare.Domain.Entities
{
  public  class BloodCoagPhysician
    {
        public int BloodCoagPhysicianId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int BloodRecordId { get; set; }

        public virtual ClientBloodCoagulationRecord BloodCoagulation { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
