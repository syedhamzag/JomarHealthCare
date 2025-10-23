using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffSurveyHandler : IRequestHandler<DeleteStaffSurveyCommand, bool>
    {
        private readonly IStaffSurveyRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffSurveyHandler(IStaffSurveyRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffSurveyCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}