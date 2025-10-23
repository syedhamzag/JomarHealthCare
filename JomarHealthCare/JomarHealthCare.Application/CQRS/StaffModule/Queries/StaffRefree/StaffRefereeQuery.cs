using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffRefereeQuery : IRequest<IQueryable<StaffReferee>>
    {
        public string Id { get; set; } = string.Empty;
    }
}