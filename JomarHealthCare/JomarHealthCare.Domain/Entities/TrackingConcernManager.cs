namespace JomarHealthCare.Domain.Entities
{
    public class TrackingConcernManager
    {
        public int TrackingConcernManagerId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int TrackingConcernNoteId { get; set; }

        public virtual TrackingConcernNote TrackingConcernNote { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
