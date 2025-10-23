using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.ServiceTypes.Commands;

public class AddServiceTypeCommand : IRequest<ServiceType>
{
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}


public class DeleteServiceTypeCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class UpdateServiceTypeCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}