using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffContractHandler : IRequestHandler<DeleteStaffContractCommand, bool>
    {
        private readonly IStaffContractRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffContractHandler(IStaffContractRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffContractCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}