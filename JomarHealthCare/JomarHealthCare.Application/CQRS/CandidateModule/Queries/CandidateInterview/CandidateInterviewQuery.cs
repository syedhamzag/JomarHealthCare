using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class CandidateInterviewQuery : IRequest<IQueryable<CandidateInterview>>
    {
        public string Id { get; set; } = string.Empty;
    }
}