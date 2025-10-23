using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Territories.Commands;

public class AddTerritoryCommand : IRequest<Territory>
{
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}


public class DeleteTerritoryCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class UpdateTerritoryCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}