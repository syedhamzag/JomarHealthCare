using JomarHealthCare.Application.DataModels.BaseRecordItem;

namespace JomarHealthCare.Application.DataModels.BaseRecord;

public class BaseRecordDataModel
{
    public int BaseRecordId { get; set; }
    public string KeyName { get; set; }
    public string Description { get; set; }
    public string CreatedBy { get; set; }

    public List<BaseRecordItemDataModel> BaseRecordItems { get; set; }
}
