using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffInfectionControlQuery : IRequest<IQueryable<StaffInfectionControl>>
    {
        public string Id { get; set; } = string.Empty;
    }
}