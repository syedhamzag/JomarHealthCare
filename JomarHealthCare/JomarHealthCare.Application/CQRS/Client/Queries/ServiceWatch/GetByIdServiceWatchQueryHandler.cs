using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Watch;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.ServiceWatch;

internal class GetByIdServiceWatchQueryHandler : IRequestHandler<GetByIdClientServiceWatchQuery, ClientServiceWatchDataModel>
{
    private readonly IClientServiceWatchRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdServiceWatchQueryHandler(IClientServiceWatchRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }


    public async Task<ClientServiceWatchDataModel> Handle(GetByIdClientServiceWatchQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);

        if (entity == null)
            return new ClientServiceWatchDataModel();

        return _mapper.Map<ClientServiceWatchDataModel>(entity);
    }
}
