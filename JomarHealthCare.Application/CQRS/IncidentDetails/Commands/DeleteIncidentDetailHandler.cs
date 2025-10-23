using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.IncidentDetails.Commands
{
    public class DeleteIncidentDetailHandler : IRequestHandler<DeleteIncidentDetailCommand, bool>
    {
        private readonly IIncidentDetailRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteIncidentDetailHandler(IIncidentDetailRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteIncidentDetailCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get().Where(s=> s.IncidentDetailId == request.IncidentDetailId)
                .Include(s => s.AssignedTo).FirstOrDefaultAsync(cancellationToken);
            if (entity == null) return false;
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}