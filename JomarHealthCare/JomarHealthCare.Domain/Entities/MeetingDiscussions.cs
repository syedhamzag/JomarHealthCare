namespace JomarHealthCare.Domain.Entities
{
    public class MeetingDiscussions
    {
        public int MeetingDiscussionId { get; set; }
        public int MeetingLogId { get; set; }
        public string Discussion { get; set; }
        public virtual MeetingLog MeetingLog { get; set; }

    }
}
