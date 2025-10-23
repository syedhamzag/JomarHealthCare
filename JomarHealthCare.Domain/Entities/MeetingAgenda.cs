namespace JomarHealthCare.Domain.Entities
{
    public class MeetingAgenda
    {
        public int MeetingAgendaId { get; set; }
        public int MeetingLogId { get; set; }
        public string Agenda { get; set; }
        public virtual MeetingLog MeetingLog { get; set; }

    }
}
