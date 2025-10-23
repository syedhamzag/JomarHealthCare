using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffSurveyQuery : IRequest<IQueryable<StaffSurvey>>
    {
        public string Id { get; set; } = string.Empty;
    }
}