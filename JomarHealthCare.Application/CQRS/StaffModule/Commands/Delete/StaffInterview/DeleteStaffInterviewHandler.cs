using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffInterviewHandler : IRequestHandler<DeleteStaffInterviewCommand, bool>
    {
        private readonly IStaffInterviewRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffInterviewHandler(IStaffInterviewRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffInterviewCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}