using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteClassOfStaffHandler : IRequestHandler<DeleteClassOfStaffCommand, bool>
    {
        private readonly IClassOfStaffRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteClassOfStaffHandler(IClassOfStaffRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteClassOfStaffCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}