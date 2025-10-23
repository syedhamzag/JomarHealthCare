using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.AreaCodes.Commands;


public class AddAreaCodeCommand : IRequest<AreaCode>
{
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}


public class DeleteAreaCodeCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class UpdateAreaCodeCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}