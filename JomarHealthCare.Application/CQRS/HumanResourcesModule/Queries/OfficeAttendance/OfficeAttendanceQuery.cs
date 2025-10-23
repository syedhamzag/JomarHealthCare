using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries
{
    public class OfficeAttendanceQuery : IRequest<IQueryable<OfficeAttendance>>
    {
        public string Id { get; set; } = string.Empty;
    }
}