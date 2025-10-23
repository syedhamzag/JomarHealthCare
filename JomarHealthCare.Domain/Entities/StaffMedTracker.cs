namespace JomarHealthCare.Domain.Entities
{
    public class StaffMedTracker
    {
        public int StaffMedTrackerId { get; set; }
        public DateTime MedTrackDate { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int RotaId { get; set; }
        public int ClientMedId { get; set; }
        public string DoseGiven { get; set; }
        public int Status { get; set; }

    }
}
