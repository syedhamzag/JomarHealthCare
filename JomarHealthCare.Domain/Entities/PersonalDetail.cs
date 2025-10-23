
namespace JomarHealthCare.Domain.Entities
{
    public class PersonalDetail
    {
        public int PersonalDetailId { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }

        public Guid? ClientId { get; set; }
    }
}
