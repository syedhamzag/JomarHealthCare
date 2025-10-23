using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.HistoryFall;


public class UpdateHistoryOfFallCommandHandler : IRequestHandler<UpdateHistoryOfFallCommand, bool>
{
    private readonly IClientHistoryOfFallRepository _repo;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public UpdateHistoryOfFallCommandHandler(IClientHistoryOfFallRepository repo, IMapper mapper, IUnitOfWork uow)
    {
        _repo = repo;
        _mapper = mapper;
        _uow = uow;
    }

    public async Task<bool> Handle(UpdateHistoryOfFallCommand request, CancellationToken cancellationToken)
    {
        var existing = await _repo.GetByKeyAsync(request.DataModel.HistoryId, new CancellationToken());
        _mapper.Map(request.DataModel, existing); // This will update the scalar fields
        _repo.Update(existing);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}
