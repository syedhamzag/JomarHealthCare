using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.HealthLiving;

public class AddHealthAndLivingCommandHandler : IRequestHandler<CreateHealthAndLivingCommand, HealthAndLivingDataModel>
{
    private readonly IClientHealthAndLivingRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddHealthAndLivingCommandHandler(IClientHealthAndLivingRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<HealthAndLivingDataModel> Handle(CreateHealthAndLivingCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<HealthAndLiving>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<HealthAndLivingDataModel>(created);
    }
}