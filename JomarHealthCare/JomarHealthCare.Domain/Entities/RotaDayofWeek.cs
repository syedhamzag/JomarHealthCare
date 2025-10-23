
namespace JomarHealthCare.Domain.Entities
{
    public class RotaDayofWeek
    {
        public int RotaDayofWeekId { get; set; }
        public string DayofWeek { get; set; }

        public bool Deleted { get; set; }

        public virtual ClientMedicationDay ClientMedicationDay { get; set; }
        public virtual ICollection<ClientRotaDays> ClientRotaDays { get; set; }
    }
}
