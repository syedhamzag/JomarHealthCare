
namespace JomarHealthCare.Domain.Entities
{
    public class ClientRotaDays : AuditableEntity
    {
        public int ClientRotaDaysId { get; set; }
        public int ClientRotaId { get; set; }
        public int? RotaDayofWeekId { get; set; }
        public int? RotaId { get; set; }
        public string StartTime { get; set; }
        public string StopTime { get; set; }
        public string WeekDay { get; set; }
        public Guid? OtherStaff { get; set; }
        public virtual Rota Rota { get; set; }
        public virtual ClientRota ClientRota { get; set; }
        public virtual RotaDayofWeek RotaDayofWeek { get; set; }
        public virtual ICollection<ClientRotaTask> ClientRotaTask { get; set; }
    }
}
