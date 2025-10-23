namespace JomarHealthCare.Domain.Entities
{
  public  class HeartRateOfficerToAct
    {
        public int HeartRateOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int HeartRateId { get; set; }

        public virtual ClientHeartRate HeartRate { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
