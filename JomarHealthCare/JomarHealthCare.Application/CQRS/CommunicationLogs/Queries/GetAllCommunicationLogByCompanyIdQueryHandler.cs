using System;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.CommunicationLogs;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.CommunicationLogs.Queries;


internal class GetAllCommunicationLogByCompanyIdQueryHandler : IRequestHandler<GetAllCommunicationLogByIdQuery, List<CommunicationLogDataModel>>
{
    private readonly ICommunicationLogRepository _repository;

    public GetAllCommunicationLogByCompanyIdQueryHandler(ICommunicationLogRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<CommunicationLogDataModel>> Handle(GetAllCommunicationLogByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.id).Include(x => x.Attendee).Include(x => x.Apologies).ToListAsync(); // This method should return all records.

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