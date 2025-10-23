using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffQuery : IRequest<IQueryable<ApplicationUser>>
    {
        public string Id { get; set; } = string.Empty;
    }
}