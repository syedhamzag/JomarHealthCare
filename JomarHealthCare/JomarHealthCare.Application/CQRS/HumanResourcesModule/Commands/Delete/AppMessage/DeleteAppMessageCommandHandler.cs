using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class DeleteAppMessageCommandHandler : IRequestHandler<DeleteAppMessageCommand, bool>
{
    private readonly IAppMessageRepository _repo;
    private readonly IUnitOfWork _uow;

    public DeleteAppMessageCommandHandler(IAppMessageRepository repo, IUnitOfWork uow)
    {
        _repo = repo;
        _uow = uow;
    }

    public async Task<bool> Handle(DeleteAppMessageCommand request, CancellationToken cancellationToken)
    {
        var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
        if (entity == null) return false;

        _repo.Delete(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}
}
