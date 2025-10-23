using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ReportedConcerns.Commands
{
    public class DeleteReportedConcernHandler : IRequestHandler<DeleteReportedConcernCommand, bool>
    {
        private readonly IReportedConcernRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteReportedConcernHandler(IReportedConcernRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteReportedConcernCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get().Where(s=> s.ReportedConcernId == request.ReportedConcernId)
                .FirstOrDefaultAsync(cancellationToken);
            if (entity == null) return false;
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}