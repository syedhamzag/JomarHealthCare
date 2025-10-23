using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Commands
{
    public class DeleteExternalRoleAccessHandler : IRequestHandler<DeleteExternalRoleAccessCommand, bool>
    {
        private readonly IExternalRoleAccessRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteExternalRoleAccessHandler(IExternalRoleAccessRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteExternalRoleAccessCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get().Where(s=> s.ExternalAccessId == request.id)
                .FirstOrDefaultAsync(cancellationToken);
            if (entity == null) return false;
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}