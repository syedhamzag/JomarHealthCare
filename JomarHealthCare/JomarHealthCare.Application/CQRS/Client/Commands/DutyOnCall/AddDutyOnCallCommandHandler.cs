using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.DutyOnCall;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.DutyOnCall;


public class AddDutyOnCallCommandHandler : IRequestHandler<CreateDutyOnCallCommand, DutyOnCallDataModel>
{
    private readonly IClientDutyOnCallRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddDutyOnCallCommandHandler(IClientDutyOnCallRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<DutyOnCallDataModel> Handle(CreateDutyOnCallCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<JomarHealthCare.Domain.Entities.DutyOnCall>(request.DataModel); // DutyOnCall type now correctly resolved
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<DutyOnCallDataModel>(created);
    }
}