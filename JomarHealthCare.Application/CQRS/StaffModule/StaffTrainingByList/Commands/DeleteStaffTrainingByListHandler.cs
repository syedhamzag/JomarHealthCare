using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffTrainingByListHandler : IRequestHandler<DeleteStaffTrainingByListCommand, bool>
    {
        private readonly IStaffTrainingByListRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffTrainingByListHandler(IStaffTrainingByListRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffTrainingByListCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.StaffTrainingByListId, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}