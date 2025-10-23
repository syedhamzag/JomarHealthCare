using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffPersonalityTestHandler : IRequestHandler<DeleteStaffPersonalityTestCommand, bool>
    {
        private readonly IStaffPersonalityTestRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffPersonalityTestHandler(IStaffPersonalityTestRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffPersonalityTestCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}