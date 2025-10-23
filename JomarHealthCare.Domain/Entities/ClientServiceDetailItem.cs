
namespace JomarHealthCare.Domain.Entities
{
   public class ClientServiceDetailItem : AuditableEntity, ICompanyEntity
    {
        public int ClientServiceDetailItemId { get; set; }
        public int ClientServiceDetailId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }

        public virtual ClientServiceDetail ClientServiceDetail { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
