namespace JomarHealthCare.Domain.Entities
{
    public class Untowards
    {
        public int UntowardsId { get; set; }
        public string TicketNumber { get; set; }
        public DateTime? Date { get; set; }
        public string Subject { get; set; }
        public TimeSpan? TimeOfCall { get; set; }
        public string PersonReporting { get; set; }
        public string PersonReportingTelephone { get; set; }
        public string PersonReportingEmail { get; set; }
        public string Details { get; set; }
        public string ActionRequired { get; set; }
        public string ActionTaken { get; set; }
        public string ActionStatus { get; set; }
        public string Priority { get; set; }
        public DateTime? ExpectedDateAndTimeOfFeedback { get; set; }
        public string IncidentType { get; set; }
        public string CreatedBy { get; set; }
    }
}
