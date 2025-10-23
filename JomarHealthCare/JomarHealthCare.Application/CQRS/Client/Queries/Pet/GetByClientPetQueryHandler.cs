using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Pet;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Pet;


internal class GetByClientPetQueryHandler : IRequestHandler<GetByClientPetQuery, ClientPetDataModel>
{
    private readonly IClientPetRepository _repository;
    private readonly IMapper _mapper;

    public GetByClientPetQueryHandler(IClientPetRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ClientPetDataModel> Handle(GetByClientPetQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new ClientPetDataModel();
        }

        return _mapper.Map<ClientPetDataModel>(entity);
    }
}