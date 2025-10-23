using MediatR;
using JomarHealthCare.Application.DataModels.ExternalUser;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Queries;


public record GetExternalRoleAccessByIdQuery(int id) : IRequest<ExternalRoleAccessDataModel>
{
}
public record GetAllExternalRoleAccessByIdQuery(Guid id) : IRequest<List<ExternalRoleAccessDataModel>>
{
}