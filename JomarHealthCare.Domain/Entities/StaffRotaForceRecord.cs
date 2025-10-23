namespace JomarHealthCare.Domain.Entities
{
    public class StaffRotaForceRecord
    {
        public int Id { get; set; }
        public int? StaffRotaPeriodId { get; set; }
        public string forcedEntry { get; set; }
        public string reasonExceeding { get; set; }
        public string Signature { get; set; }
        public string UpcomingplannedTask { get; set; }
    }
}
