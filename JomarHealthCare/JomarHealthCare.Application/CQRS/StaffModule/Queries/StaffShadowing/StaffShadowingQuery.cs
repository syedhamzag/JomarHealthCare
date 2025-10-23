using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public record StaffShadowingQuery(Guid? Id=null) : IRequest<IQueryable<StaffShadowing>>;
}
