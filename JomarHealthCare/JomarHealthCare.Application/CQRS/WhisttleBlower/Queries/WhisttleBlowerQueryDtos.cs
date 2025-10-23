using MediatR;
using JomarHealthCare.Application.DataModels.WhisttleBlowers;

namespace JomarHealthCare.Application.CQRS.WhisttleBlowers.Queries;


public record GetWhisttleBlowerByIdQuery(int id) : IRequest<WhisttleBlowerDataModel>
{
}
public record GetAllWhisttleBlowerByIdQuery(Guid id) : IRequest<List<WhisttleBlowerDataModel>>
{
}