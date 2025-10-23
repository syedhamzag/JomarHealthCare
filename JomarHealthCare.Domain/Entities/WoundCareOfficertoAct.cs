namespace JomarHealthCare.Domain.Entities
{
  public  class WoundCareOfficerToAct
    {
        public int WoundCareOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int WoundCareId { get; set; }

        public virtual ClientWoundCare WoundCare { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
