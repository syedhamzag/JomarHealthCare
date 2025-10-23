using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffEmergencyContactHandler : IRequestHandler<DeleteStaffEmergencyContactCommand, bool>
    {
        private readonly IStaffEmergencyContactRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteStaffEmergencyContactHandler(IStaffEmergencyContactRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteStaffEmergencyContactCommand request, CancellationToken cancellationToken)
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