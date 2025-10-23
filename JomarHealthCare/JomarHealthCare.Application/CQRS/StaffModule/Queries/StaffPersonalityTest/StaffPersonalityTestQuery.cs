using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public record StaffPersonalityTestQuery(Guid? Id=null) : IRequest<IQueryable<StaffPersonalityTest>>;
}
