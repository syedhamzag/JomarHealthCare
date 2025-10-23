using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.IncidentDetails;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.IncidentDetails.Queries;


internal class GetAllIncidentDetailByCompanyIdQueryHandler : IRequestHandler<GetAllIncidentDetailByIdQuery, List<IncidentDetailDataModel>>
{
    private readonly IIncidentDetailRepository _repository;

    public GetAllIncidentDetailByCompanyIdQueryHandler(IIncidentDetailRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<IncidentDetailDataModel>> Handle(GetAllIncidentDetailByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.id).Include(s => s.AssignedTo).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new IncidentDetailDataModel
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
        }).ToList();
    }
}