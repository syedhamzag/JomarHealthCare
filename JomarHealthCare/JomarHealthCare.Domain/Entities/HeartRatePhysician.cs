namespace JomarHealthCare.Domain.Entities
{
  public  class HeartRatePhysician
    {
        public int HeartRatePhysicianId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int HeartRateId { get; set; }

        public virtual ClientHeartRate HeartRate { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
