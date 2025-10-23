using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.HealthLiving;

public class UpdateHealthAndLivingCommandHandler : IRequestHandler<UpdateHealthAndLivingCommand, bool>
{
    private readonly IClientHealthAndLivingRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateHealthAndLivingCommandHandler(IClientHealthAndLivingRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateHealthAndLivingCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByKeyAsync(request.DataModel.HLId, new CancellationToken());
        _mapper.Map(request.DataModel, existing); // This will update the scalar fields
        _repo.Update(existing);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}