using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffTrainingHandler : IRequestHandler<DeleteStaffTrainingCommand, bool>
    {
        private readonly IStaffTrainingRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffTrainingHandler(IStaffTrainingRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffTrainingCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}