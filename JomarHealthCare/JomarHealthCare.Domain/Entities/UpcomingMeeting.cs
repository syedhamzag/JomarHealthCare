namespace JomarHealthCare.Domain.Entities
{
    public class UpcomingMeeting
    {
        public int Id { get; set; }
        public DateTime MeetingDate { get; set; }
        public int CalledBy { get; set; }
        public string Location { get; set; }
        public string CreatedBy { get; set; }
        public TimeSpan? Time { get; set; }
    }
}
