using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.AppointmentBookings.Commands
{
    public class DeleteAppointmentBookingHandler : IRequestHandler<DeleteAppointmentBookingCommand, bool>
    {
        private readonly IAppointmentBookingRepository _repo;
        private readonly IAppointmentBookingAttendeesRepository _attendeesRepository;
        private readonly IUnitOfWork _uow;

        public DeleteAppointmentBookingHandler(IAppointmentBookingRepository repo, IAppointmentBookingAttendeesRepository attendeesRepository,IUnitOfWork uow)
        {
            _repo = repo;
            _attendeesRepository = attendeesRepository;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteAppointmentBookingCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get().Where(s=> s.AppointmentBookingId == request.AppointmentBookingId)
                .Include(s => s.Attendee).FirstOrDefaultAsync(cancellationToken);
            if (entity == null) return false;
            foreach (var attendee in entity.Attendee.ToList())
                _attendeesRepository.Delete(attendee);
            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }




}