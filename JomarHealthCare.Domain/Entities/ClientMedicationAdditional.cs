namespace JomarHealthCare.Domain.Entities
{
    public class ClientMedicationAdditional
    {
        public int Id { get; set; }
        public int ClientMedicationPeriodId { get; set; }
        public string DoseTobeGiven { get; set; }
        public string DoseGiven { get; set; }
        public string Instruction { get; set; }
        public string FeedBack { get; set; }
        public string RotaDate { get; set; }
        public TimeSpan? Time { get; set; }
        public TimeSpan? StopTime { get; set; }
        public string Status { get; set; }
    }
}
