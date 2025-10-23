using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteOneToOneOfficerToActHandler : IRequestHandler<DeleteOneToOneOfficerToActCommand, bool>
    {
        private readonly IOneToOneOfficerToActRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteOneToOneOfficerToActHandler(IOneToOneOfficerToActRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteOneToOneOfficerToActCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}