namespace JomarHealthCare.Domain.Entities
{
  public  class SpotCheckOfficerToAct
    {
        public int SpotCheckOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int SpotCheckId { get; set; }

        // public virtual StaffSpotCheck SpotCheck { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
