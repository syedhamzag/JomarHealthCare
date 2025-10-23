namespace JomarHealthCare.Domain.Entities
{
    public  class CommunicationLogAttendees
    {
        public int CommunicationLogAttendeesId { get; set; }
        public Guid AttendeesId { get; set; }
        public int CommunicationLogId { get; set; }


        public virtual CommunicationLog CommunicationLog { get; set; }
    }
    public class CommunicationLogApologies
    {
        public int CommunicationLogApologiesId { get; set; }
        public Guid ApologiesId { get; set; }
        public int CommunicationLogId { get; set; }
        public virtual CommunicationLog CommunicationLog { get; set; }
    }
}
