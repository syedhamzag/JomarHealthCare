using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Pet;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Pet;

public class AddClientPetCommandHandler : IRequestHandler<CreateClientPetCommand, ClientPetDataModel>
{
    private readonly IClientPetRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddClientPetCommandHandler(IClientPetRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientPetDataModel> Handle(CreateClientPetCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Pets>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ClientPetDataModel>(created);
    }
}