using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffAdlObsQuery : IRequest<IQueryable<StaffAdlObs>>
    {
        public string Id { get; set; } = string.Empty;
    }
}