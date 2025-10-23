namespace JomarHealthCare.Domain.Entities
{
  public  class OxygenLvlPhysician
    {
        public int OxygenLvlPhysicianId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int OxygenLvlId { get; set; }

        public virtual ClientOxygenLvl OxygenLvl { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
