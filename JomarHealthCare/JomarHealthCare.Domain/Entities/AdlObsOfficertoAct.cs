namespace JomarHealthCare.Domain.Entities
{
  public  class AdlObsOfficerToAct
    {
        public int AdlObsOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int ObservationId { get; set; }

        public virtual StaffAdlObs AdlObs { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
