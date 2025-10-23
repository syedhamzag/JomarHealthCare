using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffSpotCheckQuery : IRequest<IQueryable<StaffSpotCheck>>
    {
        public string Id { get; set; } = string.Empty;
    }
}