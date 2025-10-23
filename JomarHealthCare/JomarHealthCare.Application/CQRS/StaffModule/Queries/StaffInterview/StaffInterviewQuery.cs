using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffInterviewQuery : IRequest<IQueryable<StaffInterview>>
    {
        public string Id { get; set; } = string.Empty;
    }
}