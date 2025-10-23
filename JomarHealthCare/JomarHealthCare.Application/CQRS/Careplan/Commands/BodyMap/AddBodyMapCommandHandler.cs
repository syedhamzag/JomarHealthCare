using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.BodyMap;

public class AddBodyMapCommandHandler : IRequestHandler<CreateBodyMapCommand, BodyMapDataModel>
{
    private readonly IBodyMapRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddBodyMapCommandHandler(IBodyMapRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<BodyMapDataModel> Handle(CreateBodyMapCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<JomarHealthCare.Domain.Entities.BodyMap>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<BodyMapDataModel>(created);
    }
}