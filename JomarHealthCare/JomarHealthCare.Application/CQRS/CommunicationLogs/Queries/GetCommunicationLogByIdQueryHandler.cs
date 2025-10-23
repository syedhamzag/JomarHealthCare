using MediatR;
using JomarHealthCare.Application.DataModels.CommunicationLogs;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.CommunicationLogs.Queries;

internal class GetCommunicationLogByIdQueryHandler : IRequestHandler<GetCommunicationLogByIdQuery, CommunicationLogDataModel>
{
    private readonly ICommunicationLogRepository _repository;

    public GetCommunicationLogByIdQueryHandler(ICommunicationLogRepository repository)
    {
        _repository = repository;
    }

    public async Task<CommunicationLogDataModel> Handle(GetCommunicationLogByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new CommunicationLogDataModel
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
            CompanyId = entity.CompanyId.ToString(),
            ApologiesName = entity.ApologiesName,
            AttendeeName = entity.AttendeeName,
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
        };
    }
}