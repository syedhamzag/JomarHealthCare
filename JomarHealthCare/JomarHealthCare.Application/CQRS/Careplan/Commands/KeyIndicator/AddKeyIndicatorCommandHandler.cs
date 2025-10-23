using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.KeyIndicator;
public class AddKeyIndicatorCommandHandler : IRequestHandler<CreateKeyIndicatorCommand, KeyIndicatorDataModel>
{
    private readonly IKeyIndicatorRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddKeyIndicatorCommandHandler(IKeyIndicatorRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<KeyIndicatorDataModel> Handle(CreateKeyIndicatorCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<KeyIndicators>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<KeyIndicatorDataModel>(created);
    }
}