using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.ClientRota;

internal class GetByIdClientRotaQueryHandler : IRequestHandler<GetByIdClientRotaQuery, List<ClientRotaDataModel>>
{
    private readonly IClientRotaRepository _repository;
    private readonly IMapper _mapper;

    public GetByIdClientRotaQueryHandler(IClientRotaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ClientRotaDataModel>> Handle(GetByIdClientRotaQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get()
                    .Where(x => x.ClientId == request.clientId)
                    .Include(x => x.ClientRotaDays)
                        .ThenInclude(d => d.ClientRotaTask)
                    .ToListAsync(cancellationToken);


        if (entities == null || entities.Count == 0)
            return new List<ClientRotaDataModel>();

        return _mapper.Map<List<ClientRotaDataModel>>(entities);
    }
}