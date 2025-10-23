using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffWorkTeamQuery : IRequest<IQueryable<StaffWorkTeam>>
    {
        public string Id { get; set; } = string.Empty;
    }
}