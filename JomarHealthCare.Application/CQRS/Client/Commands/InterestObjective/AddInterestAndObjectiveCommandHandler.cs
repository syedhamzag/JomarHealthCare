using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Client.InterestObjective;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.InterestObjective;


public class AddInterestAndObjectiveCommandHandler : IRequestHandler<CreateInterestAndObjectiveCommand, ClientInterestAndObjectiveDataModel>
{
    private readonly IClientInterestAndObjectiveRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddInterestAndObjectiveCommandHandler(IClientInterestAndObjectiveRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<ClientInterestAndObjectiveDataModel> Handle(CreateInterestAndObjectiveCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<InterestAndObjective>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ClientInterestAndObjectiveDataModel>(created);
    }
}
