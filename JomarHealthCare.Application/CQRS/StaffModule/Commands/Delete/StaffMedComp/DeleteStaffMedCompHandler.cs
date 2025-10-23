using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    internal class DeleteStaffMedCompHandler : IRequestHandler<DeleteStaffMedCompCommand, bool>
    {
        private readonly IStaffMedCompRepository _repo;

        public DeleteStaffMedCompHandler(IStaffMedCompRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteStaffMedCompCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get(x => x.MedCompId == request.Id).FirstOrDefaultAsync();
            if (entity == null)
                throw new KeyNotFoundException("Staff MedComp not found");
            _repo.Delete(entity);
            return true;
        }
    }
}