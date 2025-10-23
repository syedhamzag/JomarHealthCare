using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.CommunicationLogs;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.CommunicationLogs.Queries;


internal class GetAllCommunicationLogByClientIdQueryHandler : IRequestHandler<GetAllCommunicationLogByAttendeeIdQuery, List<CommunicationLogDataModel>>
{
    private readonly ICommunicationLogRepository _repository;

    public GetAllCommunicationLogByClientIdQueryHandler(ICommunicationLogRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<CommunicationLogDataModel>> Handle(GetAllCommunicationLogByAttendeeIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Include(x => x.Attendee).Include(s => s.Apologies).Where(x => x.Attendee.Any(attendee => attendee.AttendeesId == request.attendeeId) ||
        x.Apologies.Any(apology => apology.ApologiesId == request.attendeeId)).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new CommunicationLogDataModel
        {
            CommunicationLogId = entity.CommunicationLogId,
            MeetingTitle = entity.MeetingTitle,
            Date = entity.Date,
            Time = TimeOnly.FromDateTime(entity.Time),
            MinuteTaker = entity.MinuteTaker,
            ActionItems = entity.ActionItems,
            CaseNo = entity.CaseNo,
            ClinicalPresentation = entity.ClinicalPresentation,
            Discussion = entity.Discussion,
            Plan = entity.Plan,
            Status = entity.Status,
            ApologiesName = entity.ApologiesName,
            AttendeeName = entity.AttendeeName,
            CompanyId = entity.CompanyId.ToString(),
            Attendee = entity.Attendee.Select(pr => new CommunicationLogAttendeesDataModel
            {
                CommunicationLogAttendeesId = pr.CommunicationLogAttendeesId,
                AttendeesId = pr.AttendeesId.ToString(),
                CommunicationLogId = pr.CommunicationLogId,
            }).ToList(),
            Apologies = entity.Apologies.Select(pa => new CommunicationLogApologiesDataModel
            {
                CommunicationLogApologiesId = pa.CommunicationLogApologiesId,
                ApologiesId = pa.ApologiesId.ToString(),
                CommunicationLogId = pa.CommunicationLogId
            }).ToList(),
        }).ToList();
    }
}