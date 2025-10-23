using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.BaseRecord.Commands;

public class CreateBaseRecordsCommand : IRequest<BaseRecordModel>
{
    public string KeyName { get; set; }
    public string Description { get; set; }
    public string CreatedBy { get; set; }

}


public class DeleteBaseRecordsCommand : IRequest<bool>
{
    public int BaseRecordId { get; set; }
}

public class UpdateBaseRecordsCommand : IRequest<bool>
{
    public int BaseRecordId { get; set; }
    public string KeyName { get; set; }
    public string Description { get; set; }
    public string CreatedBy { get; set; }
}
