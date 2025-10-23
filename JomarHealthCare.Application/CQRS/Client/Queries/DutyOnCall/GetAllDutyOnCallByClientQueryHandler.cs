using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.DutyOnCall;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.DutyOnCall;


internal class GetAllDutyOnCallByClientQueryHandler : IRequestHandler<GetAllDutyOnCallByClientQuery, List<DutyOnCallDataModel>>
{
    private readonly IClientDutyOnCallRepository _repository;

    public GetAllDutyOnCallByClientQueryHandler(IClientDutyOnCallRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<DutyOnCallDataModel>> Handle(GetAllDutyOnCallByClientQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).Include(x => x.PersonToAct).Include(x => x.PersonResponsible).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new DutyOnCallDataModel
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
        }).ToList();
    }
}