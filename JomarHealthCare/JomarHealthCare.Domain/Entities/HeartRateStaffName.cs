namespace JomarHealthCare.Domain.Entities
{
  public  class HeartRateStaffName
    {
        public int HeartRateStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int HeartRateId { get; set; }

        public virtual ClientHeartRate HeartRate { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
