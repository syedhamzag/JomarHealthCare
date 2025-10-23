namespace JomarHealthCare.Domain.Entities
{
    public class BaseRecordItemModel
    {
        public int BaseRecordItemId { get; set; }
        public int BaseRecordId { get; set; }
        public string ValueName { get; set; }
        public bool HasGoogleForm { get; set; }
        public bool Deleted { get; set; }
        public string AddLink { get; set; }
        public string ViewLink { get; set; }
        public string CreatedBy { get; set; }
        public int ExpiryInMonths { get; set; }
        public virtual BaseRecordModel BaseRecord { get; set; }
    }
}
