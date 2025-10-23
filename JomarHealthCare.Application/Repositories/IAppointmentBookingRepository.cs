using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Repositories;

public interface IAppointmentBookingRepository : IGenericRepository<AppointmentBooking>
{
}
public interface IAppointmentBookingAttendeesRepository : IGenericRepository<AppointmentBookingAttendees>
{
}
