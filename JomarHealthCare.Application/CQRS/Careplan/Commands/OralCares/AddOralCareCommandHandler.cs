using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.OralCares;


public class AddOralCareCommandHandler : IRequestHandler<CreateOralCareCommand, OralCareDataModel>
{
    private readonly IOralCareRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddOralCareCommandHandler(IOralCareRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<OralCareDataModel> Handle(CreateOralCareCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<OralCare>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<OralCareDataModel>(created);
    }
}