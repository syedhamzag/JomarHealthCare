using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public class DeleteStaffSupervisionAppraisalHandler : IRequestHandler<DeleteStaffSupervisionAppraisalCommand, bool>
    {
        private readonly IStaffSupervisionAppraisalRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffSupervisionAppraisalHandler(IStaffSupervisionAppraisalRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffSupervisionAppraisalCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
