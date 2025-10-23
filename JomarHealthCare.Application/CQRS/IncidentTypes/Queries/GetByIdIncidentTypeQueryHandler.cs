using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.IncidentType;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.IncidentTypes.Queries;


internal class GetByIdIncidentTypeQueryHandler : IRequestHandler<GetByIdIncidentTypeQuery, IncidentTypeDataModel>
{
    private readonly IIncidentTypeRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdIncidentTypeQueryHandler(IIncidentTypeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IncidentTypeDataModel> Handle(GetByIdIncidentTypeQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().FirstOrDefaultAsync(x => x.IncidentTypeId == request.id);
        if (entity == null)
        {
            return new IncidentTypeDataModel();
        }
        return new IncidentTypeDataModel
        {
            IncidentTypeId = entity.IncidentTypeId,
            IncidentTypes = entity.IncidentTypes,
            CompanyId = entity.CompanyId,
        };
    }
}