
namespace JomarHealthCare.Domain.Entities
{
    public class ClientInvoiceRate : AuditableEntity
    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public string Period { get; set; }
        public decimal? Rate { get; set; }
        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
