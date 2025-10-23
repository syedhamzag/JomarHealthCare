namespace JomarHealthCare.Domain.Entities
{
    public class MeetingActionableItem
    {
        public int MeetingActionableItemId { get; set; }
        public int MeetingLogId { get; set; }
        public string ActionableItem { get; set; }
        public virtual MeetingLog MeetingLog { get; set; }

    }
}
