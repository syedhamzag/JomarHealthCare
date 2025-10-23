using MediatR;
using JomarHealthCare.Domain.Entities;


namespace JomarHealthCare.Application.CQRS.BaseRecordItem.Commands;


public class CreateBaseRecordItemCommand : IRequest<BaseRecordItemModel>
{
    public int BaseRecordId { get; set; }
    public string ValueName { get; set; }
    public string CreatedBy { get; set; }
}


public class DeleteBaseRecordItemCommand : IRequest<bool>
{
    public int BaseRecordItemId { get; set; }
}

public class UpdateBaseRecordItemCommand : IRequest<bool>
{
    public int BaseRecordItemId { get; set; }
    public int BaseRecordId { get; set; }
    public string ValueName { get; set; }
    public string CreatedBy { get; set; }
}
