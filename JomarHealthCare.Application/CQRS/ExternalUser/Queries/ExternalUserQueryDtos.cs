using MediatR;
using JomarHealthCare.Application.DataModels.ExternalUser;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Queries;


public record GetExternalUserByIdQuery(int id) : IRequest<ExternalUserDataModel>
{
}
public record GetAllExternalUserByIdQuery(Guid id) : IRequest<List<ExternalUserDataModel>>
{
}