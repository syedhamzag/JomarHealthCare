namespace JomarHealthCare.Domain.Entities
{
   public class CommunicationTo
    {
        public int CommunicationToId { get; set; }
        public int To { get; set; }

        public virtual Communication Communication { get; set; }
    }
}
