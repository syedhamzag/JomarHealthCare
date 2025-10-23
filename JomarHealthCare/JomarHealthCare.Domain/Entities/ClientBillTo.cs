
namespace JomarHealthCare.Domain.Entities
{
    public class ClientBillTo : AuditableEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string BillTo { get; set; }

        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
