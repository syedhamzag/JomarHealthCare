using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class StaffRotaPartner
    {
        public int StaffRotaPartnerId { get; set; }
        public int StaffRotaId { get; set; }
        public Guid? StaffId { get; set; }
        public virtual StaffRota StaffRota { get; set; }
    }
}
