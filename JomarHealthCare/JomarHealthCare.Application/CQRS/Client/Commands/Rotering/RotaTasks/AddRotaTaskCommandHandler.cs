using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.Repositories.Clients.Rotering;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.RotaTasks;

public class AddRotaTaskCommandHandler : IRequestHandler<CreateRotaTaskCommand, RotaTaskDataModel>
{
    private readonly IRotaTaskRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddRotaTaskCommandHandler(IRotaTaskRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<RotaTaskDataModel> Handle(CreateRotaTaskCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<RotaTask>(request.DataModel); // DutyOnCall type now correctly resolved
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<RotaTaskDataModel>(created);
    }
}