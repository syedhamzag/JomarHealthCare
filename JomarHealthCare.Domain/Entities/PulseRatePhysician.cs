namespace JomarHealthCare.Domain.Entities
{
  public  class PulseRatePhysician
    {
        public int PulseRatePhysicianId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int PulseRateId { get; set; }

        public virtual ClientPulseRate PulseRate { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
