using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffRefereeHandler : IRequestHandler<DeleteStaffRefereeCommand, bool>
    {
        private readonly IStaffRefereeRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteStaffRefereeHandler(IStaffRefereeRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteStaffRefereeCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null)
                return false;
            _repo.Delete(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}