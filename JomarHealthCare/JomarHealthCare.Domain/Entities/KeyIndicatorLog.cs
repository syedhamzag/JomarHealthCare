namespace JomarHealthCare.Domain.Entities
{
    public class KeyIndicatorLog
    {
        public int KeyIndicatorLogId { get; set; }
        public int KeyId { get; set; }
        public int BaseRecordId { get; set; }

        public virtual KeyIndicators KeyIndicators { get; set; }
    }
}
