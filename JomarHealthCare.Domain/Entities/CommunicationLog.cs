namespace JomarHealthCare.Domain.Entities
{
    public class CommunicationLog
    {
        public CommunicationLog()
        {
            Attendee = new HashSet<CommunicationLogAttendees>();
            Apologies = new HashSet<CommunicationLogApologies>();
        }
        public int CommunicationLogId { get; set; }
        public string MeetingTitle { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string MinuteTaker { get; set; }
        public string ClinicalPresentation { get; set; }
        public string Discussion { get; set; }

        public string Plan { get; set; }
        public string ActionItems { get; set; }
        public string CaseNo { get; set; }
        public int Status { get; set; }
        public string AttendeeName { get; set; }
        public string ApologiesName { get; set; }
        public Guid CompanyId { get; set; }
        public virtual ICollection<CommunicationLogAttendees> Attendee { get; set; }
        public virtual ICollection<CommunicationLogApologies> Apologies { get; set; }
    }
}
