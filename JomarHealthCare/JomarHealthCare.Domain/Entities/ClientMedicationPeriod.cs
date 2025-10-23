namespace JomarHealthCare.Domain.Entities
{
    public class ClientMedicationPeriod
    {
        public int ClientMedicationPeriodId { get; set; }
        public int? ClientRotaTypeId { get; set; }
        public int? ClientMedicationDayId { get; set; }
        public int? RotaId { get; set; }
        public string StartTime { get; set; }
        public string StopTime { get; set; }
        public bool MedLiveTrackerDelete { get; set; }
        public virtual ClientMedicationDay ClientMedicationDay { get; set; }
        public virtual ClientRotaType ClientRotaType { get; set; }
    }
}
