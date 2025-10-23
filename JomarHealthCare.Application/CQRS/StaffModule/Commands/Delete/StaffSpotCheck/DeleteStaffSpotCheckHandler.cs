using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public class DeleteStaffSpotCheckHandler : IRequestHandler<DeleteStaffSpotCheckCommand, bool>
    {
        private readonly IStaffSpotCheckRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffSpotCheckHandler(IStaffSpotCheckRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffSpotCheckCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
