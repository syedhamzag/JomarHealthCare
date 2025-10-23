namespace JomarHealthCare.Domain.Entities
{
    public class MedicationTrackerDelete
    {
        public int Id { get; set; }
        public int clientMedicationPeriodId { get; set; }
        public int StaffRotaId { get; set; }
        public DateTime Date { get; set; }
    }
}
