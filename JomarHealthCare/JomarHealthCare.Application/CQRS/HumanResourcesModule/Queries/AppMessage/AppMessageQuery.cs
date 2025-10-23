using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries
{
    public class AppMessageQuery : IRequest<IQueryable<AppMessage>>
{
    public string Id { get; set; } = string.Empty;
}
}