using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class InterviewQuestionQuery : IRequest<IQueryable<InterviewQuestion>>
    {
        public string Id { get; set; } = string.Empty;
    }
}