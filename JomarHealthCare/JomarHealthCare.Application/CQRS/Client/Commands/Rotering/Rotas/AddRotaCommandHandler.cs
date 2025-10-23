using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.Rotas;

public class AddRotaCommandHandler : IRequestHandler<CreateRotaCommand, RotaDataModel>
{
    private readonly IRotaRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddRotaCommandHandler(IRotaRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<RotaDataModel> Handle(CreateRotaCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Rota>(request.DataModel); // DutyOnCall type now correctly resolved
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<RotaDataModel>(created);
    }
}