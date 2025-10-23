using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class RotaStaff
    {
        public Guid StaffId { get; set; }
        public int StaffMedRotaId { get; set; }
        public virtual StaffMedRota StaffMedRota { get; set; }
    }
}
