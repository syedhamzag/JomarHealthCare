namespace JomarHealthCare.Domain.Entities
{
  public  class SeizureOfficerToAct
    {
        public int SeizureOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int SeizureId { get; set; }

        public virtual ClientSeizure Seizure { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
