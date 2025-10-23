using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Commands
{
    public class DeleteExternalUserHandler : IRequestHandler<DeleteExternalUserCommand, bool>
    {
        private readonly IExternalRoleRepository _repo;
        private readonly IApplicationUserRepository _applicationUser;
        private readonly IUnitOfWork _uow;

        public DeleteExternalUserHandler(IExternalRoleRepository repo, IApplicationUserRepository applicationUser,IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
            _applicationUser = applicationUser;
        }

        public async Task<bool> Handle(DeleteExternalUserCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get().Where(s=> s.ExternalId == request.id)
                .FirstOrDefaultAsync(cancellationToken);
            var user = await _applicationUser.GetByKeyAsync(entity.UserId, cancellationToken);
            if (entity == null || user == null) return false;
            _repo.Delete(entity);
            _applicationUser.Delete(user);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}