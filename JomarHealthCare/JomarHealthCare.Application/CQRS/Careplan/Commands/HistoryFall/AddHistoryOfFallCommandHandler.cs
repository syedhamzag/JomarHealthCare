using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.HistoryFall;

public class AddHistoryOfFallCommandHandler : IRequestHandler<CreateHistoryOfFallCommand, HistoryOfFallDataModel>
{
    private readonly IClientHistoryOfFallRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddHistoryOfFallCommandHandler(IClientHistoryOfFallRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<HistoryOfFallDataModel> Handle(CreateHistoryOfFallCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<HistoryOfFall>(request.DataModel);
        var created = await _repo.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<HistoryOfFallDataModel>(created);
    }
}