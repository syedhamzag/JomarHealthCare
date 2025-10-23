using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.RotaType;

public class AddRotaTypeCommandHandler : IRequestHandler<CreateRotaTypeCommand, ClientRotaTypeDataModel>
{
    private readonly IClientRotaTypeRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddRotaTypeCommandHandler(IClientRotaTypeRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientRotaTypeDataModel> Handle(CreateRotaTypeCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<ClientRotaType>(request.DataModel); // DutyOnCall type now correctly resolved
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ClientRotaTypeDataModel>(created);
    }
}