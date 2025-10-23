
namespace JomarHealthCare.Domain.Entities
{
    public class ClientHobbies : AuditableEntity
    {
        public int CHId { get; set; }
        public int HId { get; set; }
        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }

        public virtual Hobbies Hobbies { get; set; }
    }
}
