namespace JomarHealthCare.Domain.Entities
{
  public  class BodyTempPhysician
    {
        public int BodyTempPhysicianId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int BodyTempId { get; set; }

        public virtual ClientBodyTemp BodyTemp { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
