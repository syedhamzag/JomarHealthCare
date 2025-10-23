using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.IncidentType;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.IncidentTypes.Queries;


internal class GetAllIncidentTypeQueryHandler : IRequestHandler<GetAllIncidentTypeQuery, List<IncidentTypeDataModel>>
{

    private readonly IIncidentTypeRepository _repository;
    private readonly IMapper _mapper;

    public GetAllIncidentTypeQueryHandler(IIncidentTypeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<IncidentTypeDataModel>> Handle(GetAllIncidentTypeQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == null && !x.Deleted).ToListAsync(); // This method should return all records.
        return entities.Select(entity => new IncidentTypeDataModel
        {
            IncidentTypeId = entity.IncidentTypeId,
            IncidentTypes = entity.IncidentTypes,
            CompanyId = entity.CompanyId,
        }).ToList();
    }
}