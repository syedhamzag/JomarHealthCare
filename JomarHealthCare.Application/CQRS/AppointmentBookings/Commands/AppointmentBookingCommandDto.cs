using MediatR;
using JomarHealthCare.Application.DataModels.AppointmentBookings;

namespace JomarHealthCare.Application.CQRS.AppointmentBookings.Commands
{
    public record CreateAppointmentBookingCommand(AppointmentBookingDataModel DataModel) : IRequest<AppointmentBookingDataModel>;
    public record DeleteAppointmentBookingCommand(int AppointmentBookingId) : IRequest<bool>;
    public record UpdateAppointmentBookingCommand(AppointmentBookingDataModel DataModel) : IRequest<bool>;
}