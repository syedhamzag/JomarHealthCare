using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.PhysicalAbility;

public class UpdatePhysicalAbilityCommandHandler : IRequestHandler<UpdatePhysicalAbilityCommand, bool>
{
    private readonly IClientPhysicalAbilityRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdatePhysicalAbilityCommandHandler(IClientPhysicalAbilityRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdatePhysicalAbilityCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByKeyAsync(request.DataModel.PhysicalId, new CancellationToken());
        _mapper.Map(request.DataModel, existing); // This will update the scalar fields
        _repo.Update(existing);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}