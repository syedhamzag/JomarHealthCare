
namespace JomarHealthCare.Domain.Entities
{
    public class ComplainRegistorClients
    {
        public int Id { get; set; }
        public int ComplainRegistorId { get; set; }
        public virtual ComplainRegistor ComplainRegistor { get; set; }
        public Guid ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
