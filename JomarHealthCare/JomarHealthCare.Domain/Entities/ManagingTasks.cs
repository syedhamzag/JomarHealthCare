
namespace JomarHealthCare.Domain.Entities
{
    public class ManagingTasks
    {
        public int TaskId { get; set; }
        public int? Task { get; set; }
        public string Help { get; set; }
        public int? Status { get; set; }
        public Guid? ClientId { get; set; }
    }
}
