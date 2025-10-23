namespace JomarHealthCare.Domain.Entities
{
    public class Communication
    {
        public Communication()
        {
          //  Tos = new HashSet<CommunicationTo>();
        }
        public int CommunicationId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CommuncationDate { get; set; }
        public bool IsRead { get; set; }

       // public virtual ICollection<CommunicationTo> Tos { get; set; }
    }
}
