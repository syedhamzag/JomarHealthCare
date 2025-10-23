using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffMedCompQuery : IRequest<IQueryable<StaffMedComp>>
    {
        public string Id { get; set; } = string.Empty;
    }
}