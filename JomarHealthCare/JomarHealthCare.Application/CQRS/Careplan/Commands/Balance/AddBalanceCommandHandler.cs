using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Balance;

public class AddBalanceCommandHandler : IRequestHandler<CreateBalanceCommand, List<BalanceDataModel>>
{
    private readonly IClientBalanceRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddBalanceCommandHandler(IClientBalanceRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<List<BalanceDataModel>> Handle(CreateBalanceCommand request, CancellationToken cancellationToken)
    {
        var clientId = request.DataModel.FirstOrDefault().ClientId;
        await _repo.DeleteByClientIdAsync((Guid)clientId, cancellationToken);


        var entity = _mapper.Map<List<JomarHealthCare.Domain.Entities.Balance>>(request.DataModel);
        await _repo.AddRangeAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return _mapper.Map<List<BalanceDataModel>>(entity);
    }
}