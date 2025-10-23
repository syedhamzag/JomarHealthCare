using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Capacity;

public class AddCapacityCommandHandler : IRequestHandler<CreateCapacityCommand, CapacityDataModel>
{
    private readonly ICapacityRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddCapacityCommandHandler(ICapacityRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<CapacityDataModel> Handle(CreateCapacityCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<JomarHealthCare.Domain.Entities.Capacity>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<CapacityDataModel>(created);
    }
}