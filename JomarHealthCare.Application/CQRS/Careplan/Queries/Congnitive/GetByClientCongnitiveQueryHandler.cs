using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Congnitive;

internal class GetByClientCongnitiveQueryHandler : IRequestHandler<GetByClientCongnitiveQuery, CongnitiveDataModel>
{
    private readonly IClientCongnitiveRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientCongnitiveQueryHandler(IClientCongnitiveRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<CongnitiveDataModel> Handle(GetByClientCongnitiveQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new CongnitiveDataModel();
        }

        return _mapper.Map<CongnitiveDataModel>(entity);
    }
}
