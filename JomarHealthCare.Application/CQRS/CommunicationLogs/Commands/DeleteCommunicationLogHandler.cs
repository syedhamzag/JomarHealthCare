using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.CommunicationLogs.Commands
{
    public class DeleteCommunicationLogHandler : IRequestHandler<DeleteCommunicationLogCommand, bool>
    {
        private readonly ICommunicationLogRepository _repo;
        private readonly ICommunicationLogAttendeesRepository _attendeesRepository;
        private readonly ICommunicationLogApologiesRepository _apologiesRepository;
        private readonly IUnitOfWork _uow;

        public DeleteCommunicationLogHandler(ICommunicationLogRepository repo, ICommunicationLogAttendeesRepository attendeesRepository, ICommunicationLogApologiesRepository apologiesRepository, IUnitOfWork uow)
        {
            _repo = repo;
            _attendeesRepository = attendeesRepository;
            _apologiesRepository = apologiesRepository;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteCommunicationLogCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.CommunicationLogId, cancellationToken);
            if (entity == null) return false;
            foreach (var attendee in entity.Attendee.ToList())
                _attendeesRepository.Delete(attendee);

            foreach (var apology in entity.Apologies.ToList())
                _apologiesRepository.Delete(apology);
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}