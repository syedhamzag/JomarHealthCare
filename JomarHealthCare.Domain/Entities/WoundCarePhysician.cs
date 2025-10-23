namespace JomarHealthCare.Domain.Entities
{
  public  class WoundCarePhysician
    {
        public int WoundCarePhysicianId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int WoundCareId { get; set; }

        public virtual ClientWoundCare WoundCare { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
