using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffHolidayQuery : IRequest<IQueryable<StaffHoliday>>
    {
        public string Id { get; set; } = string.Empty;
    }
}