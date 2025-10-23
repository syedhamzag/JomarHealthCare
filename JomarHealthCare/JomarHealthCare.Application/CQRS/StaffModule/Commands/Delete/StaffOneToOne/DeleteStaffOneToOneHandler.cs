using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    internal class DeleteStaffOneToOneHandler : IRequestHandler<DeleteStaffOneToOneCommand, bool>
    {
        private readonly IStaffOneToOneRepository _repo;

        public DeleteStaffOneToOneHandler(IStaffOneToOneRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteStaffOneToOneCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get(x => x.OneToOneId == request.Id).FirstOrDefaultAsync();
            if (entity == null)
                throw new KeyNotFoundException("Staff OneToOne not found");
            _repo.Delete(entity);
            return true;
        }
    }
}