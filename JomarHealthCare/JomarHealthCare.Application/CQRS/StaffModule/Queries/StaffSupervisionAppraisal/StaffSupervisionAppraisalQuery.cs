using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffSupervisionAppraisalQuery : IRequest<IQueryable<StaffSupervisionAppraisal>>
    {
        public string Id { get; set; } = string.Empty;
    }
}