using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class ClassOfStaffQuery : IRequest<IQueryable<ClassOfStaff>>
    {
        public string Id { get; set; } = string.Empty;
    }
}