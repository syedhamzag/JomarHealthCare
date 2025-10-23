namespace JomarHealthCare.Domain.Entities
{
    public class BaseRecordModel
    {
        public BaseRecordModel()
        {
            BaseRecordItems = new HashSet<BaseRecordItemModel>();
        }
        public int BaseRecordId { get; set; }
        public string KeyName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<BaseRecordItemModel> BaseRecordItems { get; set; }
    }
}
