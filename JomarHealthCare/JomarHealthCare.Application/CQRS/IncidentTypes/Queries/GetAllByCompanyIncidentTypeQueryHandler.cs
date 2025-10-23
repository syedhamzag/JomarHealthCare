using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.IncidentType;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.IncidentTypes.Queries;

internal class GetAllByCompanyIncidentTypeQueryHandler : IRequestHandler<GetAllByCompanyIdIncidentTypeQuery, List<IncidentTypeDataModel>>
{
    private readonly IIncidentTypeRepository _repository;
    private readonly IMapper _mapper;

    public GetAllByCompanyIncidentTypeQueryHandler(IIncidentTypeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<IncidentTypeDataModel>> Handle(GetAllByCompanyIdIncidentTypeQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == null || x.CompanyId == request.companyId && !x.Deleted).ToListAsync();

        return entities.Select(entity => new IncidentTypeDataModel
        {
            IncidentTypeId = entity.IncidentTypeId,
            IncidentTypes = entity.IncidentTypes,
            CompanyId = entity.CompanyId,
        }).ToList();
    }
}