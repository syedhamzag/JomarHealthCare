using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.PhysicalAbility;


public class AddPhysicalAbilityCommandHandler : IRequestHandler<CreatePhysicalAbilityCommand, List<PhysicalAbilityDataModel>>
{
    private readonly IClientPhysicalAbilityRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddPhysicalAbilityCommandHandler(IClientPhysicalAbilityRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<List<PhysicalAbilityDataModel>> Handle(CreatePhysicalAbilityCommand request, CancellationToken cancellationToken)
    {
        var clientId = request.DataModel.FirstOrDefault().ClientId;
        await _repo.DeleteByClientIdAsync((Guid)clientId, cancellationToken);

        var entity = _mapper.Map<List<JomarHealthCare.Domain.Entities.PhysicalAbility>>(request.DataModel);
        await _repo.AddRangeAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<List<PhysicalAbilityDataModel>>(entity);
    }
}