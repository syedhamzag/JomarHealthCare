using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Watch;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.ServiceWatch;


internal class GetByClientServiceWatchQueryHandler : IRequestHandler<GetByClientServiceWatchQuery, List<ClientServiceWatchDataModel>>
{
    private readonly IClientServiceWatchRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientServiceWatchQueryHandler(IClientServiceWatchRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ClientServiceWatchDataModel>> Handle(GetByClientServiceWatchQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync();

        if (entities == null || entities.Count == 0)
            return new List<ClientServiceWatchDataModel>();

        return _mapper.Map<List<ClientServiceWatchDataModel>>(entities);
    }
}