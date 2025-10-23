using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.OralCares;

internal class GetByClientOralCareQueryHandler : IRequestHandler<GetByClientOralCareQuery, OralCareDataModel>
{
    private readonly IOralCareRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientOralCareQueryHandler(IOralCareRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<OralCareDataModel> Handle(GetByClientOralCareQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new OralCareDataModel();
        }

        return _mapper.Map<OralCareDataModel>(entity);
    }
}

