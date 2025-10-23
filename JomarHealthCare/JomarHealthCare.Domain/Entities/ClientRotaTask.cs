namespace JomarHealthCare.Domain.Entities
{
   public class ClientRotaTask
    {
        public int ClientRotaTaskId { get; set; }
        public int RotaTaskId { get; set; }
        public int ClientRotaDaysId { get; set; }

        public virtual RotaTask RotaTask { get; set; }
        public virtual ClientRotaDays ClientRotaDays { get; set; }
    }
}
