using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.Infection;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Infection;

public class AddInfectionControlCommandHandler : IRequestHandler<CreateInfectionControlCommand, ClientInfectionControlDataModel>
{
    private readonly IClientInfectionControlRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddInfectionControlCommandHandler(IClientInfectionControlRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientInfectionControlDataModel> Handle(CreateInfectionControlCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<InfectionControl>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ClientInfectionControlDataModel>(created);
    }
}