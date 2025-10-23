namespace JomarHealthCare.Application.DataModels.BaseRecordItem;

public class BaseRecordItemDataModel
{
    public int BaseRecordItemId { get; set; }
    public int BaseRecordId { get; set; }
    public string ValueName { get; set; }
    public string CreatedBy { get; set; }
}
