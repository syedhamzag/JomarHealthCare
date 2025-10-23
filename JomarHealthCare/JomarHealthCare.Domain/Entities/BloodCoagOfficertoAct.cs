namespace JomarHealthCare.Domain.Entities
{
  public  class BloodCoagOfficerToAct
    {
        public int BloodCoagOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int BloodRecordId { get; set; }

        public virtual ClientBloodCoagulationRecord BloodCoagulation { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
