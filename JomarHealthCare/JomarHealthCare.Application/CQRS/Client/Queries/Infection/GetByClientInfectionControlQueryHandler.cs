using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.Infection;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Infection;

internal class GetByClientInfectionControlQueryHandler : IRequestHandler<GetByClientInfectionControlQuery, ClientInfectionControlDataModel>
{
    private readonly IClientInfectionControlRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientInfectionControlQueryHandler(IClientInfectionControlRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ClientInfectionControlDataModel> Handle(GetByClientInfectionControlQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new ClientInfectionControlDataModel();
        }

        return _mapper.Map<ClientInfectionControlDataModel>(entity);
    }
}
