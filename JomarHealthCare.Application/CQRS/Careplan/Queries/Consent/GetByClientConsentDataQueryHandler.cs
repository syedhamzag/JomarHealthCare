using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Consent;


internal class GetByClientConsentDataQueryHandler : IRequestHandler<GetByClientConsentDataQuery, ConsentDataModel>
{
    private readonly IConsentDataRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientConsentDataQueryHandler(IConsentDataRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ConsentDataModel> Handle(GetByClientConsentDataQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new ConsentDataModel();
        }

        return _mapper.Map<ConsentDataModel>(entity);
    }
}
