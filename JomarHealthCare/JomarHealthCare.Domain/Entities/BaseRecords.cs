namespace JomarHealthCare.Domain.Entities;

public class BaseRecords : AuditableEntity
{
    public Guid BaseRecordId { get; set; }
    public string KeyName { get; set; }
    public string Description { get; set; }
    public virtual ICollection<BaseRecordItems> BaseRecordItems { get; set; }
}
