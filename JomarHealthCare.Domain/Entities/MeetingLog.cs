namespace JomarHealthCare.Domain.Entities
{
    public class MeetingLog
    {
        public MeetingLog()
        {
            MeetingLogFacilitators = new HashSet<MeetingLogFacilitator>();
            MeetingLogResponsibleToAct = new HashSet<MeetingLogResponsibleToAct>();
            MeetingLogAttende = new HashSet<MeetingLogAttende>();
            MeetingAgenda = new HashSet<MeetingAgenda>();
            MeetingDiscussions = new HashSet<MeetingDiscussions>();
            MeetingActionableItem = new HashSet<MeetingActionableItem>();
        }

        public int MeetingLogId { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeOFMeeting { get; set; }
        public int TypeOfMeeting { get; set; }
        public string LocationOfMeeting { get; set; }
        public string TimeAllocated { get; set; }
        public DateTime DeadLineForFeedback { get; set; }
        public DateTime NextMeetingDueDate { get; set; }
        public string ClosingRemark { get; set; }
        public string NoteTakerContact { get; set; }
        public int NoteTakerId { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<MeetingLogFacilitator> MeetingLogFacilitators { get; set; }
        public virtual ICollection<MeetingLogResponsibleToAct> MeetingLogResponsibleToAct { get; set; }
        public virtual ICollection<MeetingLogAttende> MeetingLogAttende { get; set; }
        public virtual ICollection<MeetingAgenda> MeetingAgenda { get; set; }
        public virtual ICollection<MeetingDiscussions> MeetingDiscussions { get; set; }
        public virtual ICollection<MeetingActionableItem> MeetingActionableItem { get; set; }

    }
}
    