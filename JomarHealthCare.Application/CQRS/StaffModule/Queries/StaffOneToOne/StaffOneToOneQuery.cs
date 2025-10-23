using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffOneToOneQuery : IRequest<IQueryable<StaffOneToOne>>
    {
        public string Id { get; set; } = string.Empty;
    }
}