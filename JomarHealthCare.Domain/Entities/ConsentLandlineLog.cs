namespace JomarHealthCare.Domain.Entities
{
    public class ConsentLandlineLog
    {
        public int ConsentLandlineLogId { get; set; }
        public int LandlineId { get; set; }
        public int BaseRecordId { get; set; }

        public virtual ConsentLandLine ConsentLandLine { get; set; }
    }
}
