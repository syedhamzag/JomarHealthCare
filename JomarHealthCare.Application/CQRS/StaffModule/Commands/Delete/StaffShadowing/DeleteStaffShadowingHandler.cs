using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffShadowingHandler : IRequestHandler<DeleteStaffShadowingCommand, bool>
    {
        private readonly IStaffShadowingRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffShadowingHandler(IStaffShadowingRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffShadowingCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}