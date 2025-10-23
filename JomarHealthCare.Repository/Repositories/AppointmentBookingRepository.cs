using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class AppointmentBookingRepository : GenericRepository<AppointmentBooking>, IAppointmentBookingRepository
{
    public AppointmentBookingRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
public class AppointmentBookingAttendeesRepository : GenericRepository<AppointmentBookingAttendees>, IAppointmentBookingAttendeesRepository
{
    public AppointmentBookingAttendeesRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}