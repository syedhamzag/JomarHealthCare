
namespace JomarHealthCare.Domain.Entities;

public class ClientRota : AuditableEntity
{
    public int ClientRotaId { get; set; }
    public int ClientRotaTypeId { get; set; }
    public virtual ClientRotaType ClientRotaType { get; set; }
    public virtual ICollection<ClientRotaDays> ClientRotaDays { get; set; }
    public Guid? ClientId { get; set; }
    public virtual Client Client { get; set; } 
}
