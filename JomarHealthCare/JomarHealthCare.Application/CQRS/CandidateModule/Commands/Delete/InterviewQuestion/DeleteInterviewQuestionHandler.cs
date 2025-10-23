using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteInterviewQuestionHandler : IRequestHandler<DeleteInterviewQuestionCommand, bool>
    {
        private readonly IInterviewQuestionRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteInterviewQuestionHandler(IInterviewQuestionRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteInterviewQuestionCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }

}
