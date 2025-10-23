using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class ExternalRole
    {
        public int ExternalId { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public string CreatedBy { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
