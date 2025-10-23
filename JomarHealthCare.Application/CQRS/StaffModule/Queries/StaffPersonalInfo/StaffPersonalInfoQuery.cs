using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public record StaffPersonalInfoQuery(Guid? Id=null) : IRequest<IQueryable<StaffPersonalInfo>>;
}
