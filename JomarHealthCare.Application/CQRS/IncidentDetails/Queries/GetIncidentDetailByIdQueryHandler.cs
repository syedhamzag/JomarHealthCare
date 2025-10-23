using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.IncidentDetails;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.IncidentDetails.Queries;

internal class GetIncidentDetailByIdQueryHandler : IRequestHandler<GetIncidentDetailByIdQuery, IncidentDetailDataModel>
{
    private readonly IIncidentDetailRepository _repository;

    public GetIncidentDetailByIdQueryHandler(IIncidentDetailRepository repository)
    {
        _repository = repository;
    }

    public async Task<IncidentDetailDataModel> Handle(GetIncidentDetailByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.IncidentDetailId == request.id).Include(s=>s.AssignedTo).FirstOrDefaultAsync(cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new IncidentDetailDataModel
        {
            DateTime = entity.DateTime,
            FollowupAction = entity.FollowupAction,
            IncidentCauses = entity.IncidentCauses,
            IncidentDetailId = entity.IncidentDetailId,
            IncidentDetails = entity.IncidentDetails,
            PoliceNotify = entity.PoliceNotify,
            PoliceNotifyReference = entity.PoliceNotifyReference,
            Recommendations = entity.Recommendations,
            CompanyId = entity.CompanyId.ToString(),
            IncidentType = entity.IncidentType,
            Status = entity.Status,
            AssignedTo = entity.AssignedTo.Select(pr => new IncidentDetailAssignedToDataModel
            {
                Date = pr.Date,
                Description = pr.Description,
                IncidentDetailAssignedToId = pr.IncidentDetailAssignedToId,
                IncidentDetailId = pr.IncidentDetailId,
                StaffPersonalInfoId = pr.StaffPersonalInfoId.ToString()
            }).ToList()
        };
    }
}