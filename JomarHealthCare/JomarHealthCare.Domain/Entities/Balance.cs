
using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class Balance : AuditableEntity
    {
        public int BalanceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Mobility { get; set; }
        public int? Status { get; set; }
        public Guid? ClientId { get; set; }
    }
}
