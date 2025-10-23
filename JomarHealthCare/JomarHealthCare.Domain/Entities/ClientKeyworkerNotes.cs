
namespace JomarHealthCare.Domain.Entities
{
    public class ClientKeyworkerNotes
    {
        public int Id { get; set; }
        public string KeyworkerId { get; set; }
        public string OtherStaffId { get; set; }
        public string Notes { get; set; }
        public string AccessInfo { get; set; }
        public Guid? ClientId { get; set; }
    }
}
