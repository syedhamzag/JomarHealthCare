namespace JomarHealthCare.Domain.Entities;

public class BaseRecordItems : AuditableEntity
{
    public Guid BaseRecordItemId { get; set; }
    public Guid BaseRecordId { get; set; }
    public string ValueName { get; set; }
    public Guid? CompanyId { get; set; }

    public virtual BaseRecords BaseRecord { get; set; }
}
