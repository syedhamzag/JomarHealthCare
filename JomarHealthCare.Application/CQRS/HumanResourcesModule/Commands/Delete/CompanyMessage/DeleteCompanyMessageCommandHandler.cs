using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class DeleteCompanyMessageCommandHandler : IRequestHandler<DeleteCompanyMessageCommand, bool>
{
    private readonly ICompanyMessageRepository _repo;
    private readonly IUnitOfWork _uow;

    public DeleteCompanyMessageCommandHandler(ICompanyMessageRepository repo, IUnitOfWork uow)
    {
        _repo = repo;
        _uow = uow;
    }

    public async Task<bool> Handle(DeleteCompanyMessageCommand request, CancellationToken cancellationToken)
    {
        var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
        if (entity == null) return false;

        _repo.Delete(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        return true;
    }
}
}
