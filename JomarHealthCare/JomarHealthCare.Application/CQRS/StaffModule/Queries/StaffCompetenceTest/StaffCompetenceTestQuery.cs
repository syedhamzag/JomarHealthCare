using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public record StaffCompetenceTestQuery(Guid? Id=null) : IRequest<IQueryable<StaffCompetenceTest>>;
}
