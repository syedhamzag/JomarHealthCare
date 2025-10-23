namespace JomarHealthCare.Domain.Entities
{
    public class MeetingLogAttende
    {
        public int MeetingLogAttendeId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int MeetingLogId { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
        public virtual MeetingLog MeetingLog { get; set; }

    }
}
