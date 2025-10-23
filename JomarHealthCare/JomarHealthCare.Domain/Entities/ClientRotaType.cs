
namespace JomarHealthCare.Domain.Entities
{
    public class ClientRotaType
    {
        public ClientRotaType()
        {
            ClientRota = new HashSet<ClientRota>();
            ClientMedicationPeriod = new HashSet<ClientMedicationPeriod>();
            StaffRotaPeriods = new HashSet<StaffRotaPeriod>();
        }
        public int ClientRotaTypeId { get; set; }
        public string RotaType { get; set; }
        public bool Deleted { get; set; }
        public Guid? CompanyId { get; set; }
        public virtual ICollection<ClientRota> ClientRota { get; set; }
        public virtual ICollection<ClientMedicationPeriod> ClientMedicationPeriod { get; set; }
        public virtual ICollection<StaffRotaPeriod> StaffRotaPeriods { get; set; }
    }
}
