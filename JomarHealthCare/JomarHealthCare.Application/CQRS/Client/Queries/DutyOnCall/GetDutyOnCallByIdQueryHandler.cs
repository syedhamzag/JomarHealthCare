using MediatR;
using JomarHealthCare.Application.DataModels.Client.DutyOnCall;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.DutyOnCall;

internal class GetDutyOnCallByIdQueryHandler : IRequestHandler<GetClientDutyOnCallByIdQuery, DutyOnCallDataModel>
{
    private readonly IClientDutyOnCallRepository _repository;

    public GetDutyOnCallByIdQueryHandler(IClientDutyOnCallRepository repository)
    {
        _repository = repository;
    }

    public async Task<DutyOnCallDataModel> Handle(GetClientDutyOnCallByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new DutyOnCallDataModel
        {
            DutyOnCallId = entity.DutyOnCallId,
            RefNo = entity.RefNo,
            TypeOfDutyCall = entity.TypeOfDutyCall,
            Subject = entity.Subject,
            ClientInitial = entity.ClientInitial,
            DateOfIncident = entity.DateOfIncident,
            ReportedBy = entity.ReportedBy,
            DetailsOfIncident = entity.DetailsOfIncident,
            ActionTaken = entity.ActionTaken,
            DetailsRequired = entity.DetailsRequired,
            Priority = entity.Priority,
            Status = entity.Status,
            Remarks = entity.Remarks,
            Attachment = entity.Attachment,
            StaffSignature = entity.StaffSignature,
            PersonResponsible = entity.PersonResponsible.Select(pr => new DutyOnCallPersonResponsibleDataModel
            {
                PersonResponsibleId = pr.PersonResponsibleId,
                StaffPersonalInfoId = pr.StaffPersonalInfoId,
                DutyOnCallId = pr.DutyOnCallId
            }).ToList(),
            PersonToAct = entity.PersonToAct.Select(pa => new DutyOnCallPersonToActDataModel
            {
                PersonToActId = pa.PersonToActId,
                StaffPersonalInfoId = pa.StaffPersonalInfoId,
                DutyOnCallId = pa.DutyOnCallId
            }).ToList(),
            ClientId = entity.ClientId
        };
    }
}