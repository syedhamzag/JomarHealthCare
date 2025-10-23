
namespace JomarHealthCare.Domain.Entities
{
    public class ClientInvolvingParty : AuditableEntity
    {
        public int ClientInvolvingPartyId { get; set; }
        public string ClientInvolvingPartyItem { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Relationship { get; set; }

        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
