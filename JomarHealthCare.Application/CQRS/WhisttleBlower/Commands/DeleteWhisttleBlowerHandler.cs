using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.WhisttleBlowers.Commands
{
    public class DeleteWhisttleBlowerHandler : IRequestHandler<DeleteWhisttleBlowerCommand, bool>
    {
        private readonly IWhisttleBlowerRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteWhisttleBlowerHandler(IWhisttleBlowerRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteWhisttleBlowerCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get().Where(s=> s.WhisttleBlowerId == request.id)
                .FirstOrDefaultAsync(cancellationToken);
            if (entity == null) return false;
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}