using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffKeyWorkerVoiceQuery : IRequest<IQueryable<StaffKeyWorkerVoice>>
    {
        public string Id { get; set; } = string.Empty;
    }
}