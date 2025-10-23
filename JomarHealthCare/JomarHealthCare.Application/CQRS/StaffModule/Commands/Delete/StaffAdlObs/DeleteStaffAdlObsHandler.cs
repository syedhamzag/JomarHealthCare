using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffAdlObsHandler : IRequestHandler<DeleteStaffAdlObsCommand, bool>
    {
        private readonly IStaffAdlObsRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffAdlObsHandler(IStaffAdlObsRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffAdlObsCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.ObservationID, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}