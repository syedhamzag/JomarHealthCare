namespace JomarHealthCare.Domain.Entities
{
  public  class SupervisionWorkteam
    {
        public int SupervisionWorkteamId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int StaffSupervisionAppraisalId { get; set; }

        public virtual StaffSupervisionAppraisal Supervision { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
