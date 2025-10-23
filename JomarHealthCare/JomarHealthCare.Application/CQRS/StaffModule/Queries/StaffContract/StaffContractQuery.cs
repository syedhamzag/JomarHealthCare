using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffContractQuery : IRequest<IQueryable<StaffContract>>
    {
        public string Id { get; set; } = string.Empty;
    }
}