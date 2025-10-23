using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.TaskBoards.Commands
{
    public class DeleteTaskBoardHandler : IRequestHandler<DeleteTaskBoardCommand, bool>
    {
        private readonly IClientTaskBoardRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteTaskBoardHandler(IClientTaskBoardRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteTaskBoardCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.TaskID, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}