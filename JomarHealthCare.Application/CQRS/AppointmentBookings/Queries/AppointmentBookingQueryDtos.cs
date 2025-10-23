using MediatR;
using JomarHealthCare.Application.DataModels.AppointmentBookings;

namespace JomarHealthCare.Application.CQRS.AppointmentBookings.Queries;


public record GetAppointmentBookingByIdQuery() : IRequest<AppointmentBookingDataModel>
{
    public int Id { get; set; }
}
public record GetAllAppointmentBookingByIdQuery() : IRequest<List<AppointmentBookingDataModel>>
{
    public Guid CompanyId { get; set; }
}
public record GetAllAppointmentBookingByAttendeeIdQuery(Guid id) : IRequest<List<AppointmentBookingDataModel>>;