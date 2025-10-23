using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffEducationQuery : IRequest<IQueryable<StaffEducation>>
    {
        public string Id { get; set; }
    }

}