using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    internal class DeleteStaffEducationHandler : IRequestHandler<DeleteStaffEducationCommand, bool>
    {
        private readonly IStaffEducationRepository _repo;

        public DeleteStaffEducationHandler(IStaffEducationRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteStaffEducationCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get(x => x.StaffEducationId == request.Id).FirstOrDefaultAsync();
            if (entity == null)
                throw new KeyNotFoundException("Staff education not found");
            _repo.Delete(entity);
            return true;
        }
    }
}