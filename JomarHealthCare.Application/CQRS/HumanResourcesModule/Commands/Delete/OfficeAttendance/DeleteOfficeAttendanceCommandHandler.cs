using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class DeleteOfficeAttendanceCommandHandler : IRequestHandler<DeleteOfficeAttendanceCommand, bool>
    {
        private readonly IOfficeAttendanceRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteOfficeAttendanceCommandHandler(IOfficeAttendanceRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteOfficeAttendanceCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
