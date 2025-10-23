
namespace JomarHealthCare.Domain.Entities;

public class Rota : AuditableEntity
{
    public Rota()
    {
        ShiftBookings = new HashSet<StaffShiftBooking>();
        StaffRota = new HashSet<StaffRota>();
        ClientRotaDays = new HashSet<ClientRotaDays>();
    }
    public int RotaId { get; set; }
    public int NumberOfStaff { get; set; }
    public string RotaName { get; set; }
    public string Gender { get; set; }
    public string Area { get; set; }
    public Guid? CompanyId { get; set; }
    public virtual ICollection<StaffShiftBooking> ShiftBookings { get; set; }
    public virtual ICollection<StaffRota> StaffRota { get; set; }
    public virtual ICollection<ClientRotaDays> ClientRotaDays { get; set; }
}
