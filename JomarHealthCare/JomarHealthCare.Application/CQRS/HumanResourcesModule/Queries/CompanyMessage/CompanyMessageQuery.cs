using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries
{
    public class CompanyMessageQuery : IRequest<IQueryable<CompanyMessage>>
    {
        public string Id { get; set; } = string.Empty;
    }
}