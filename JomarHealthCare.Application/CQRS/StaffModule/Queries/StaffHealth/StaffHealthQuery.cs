using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffHealthQuery : IRequest<IQueryable<StaffHealth>>
    {
        public string Id { get; set; } = string.Empty;
    }
}