using MediatR;
using JomarHealthCare.Application.DataModels.AppointmentBookings;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.AppointmentBookings.Queries;

internal class GetAppointmentBookingByIdQueryHandler : IRequestHandler<GetAppointmentBookingByIdQuery, AppointmentBookingDataModel>
{
    private readonly IAppointmentBookingRepository _repository;

    public GetAppointmentBookingByIdQueryHandler(IAppointmentBookingRepository repository)
    {
        _repository = repository;
    }

    public async Task<AppointmentBookingDataModel> Handle(GetAppointmentBookingByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new AppointmentBookingDataModel
        {
            AppointmentBookingId = entity.AppointmentBookingId,
            Subject = entity.Subject,
            Date = entity.Date,
            AttendeeName = entity.AttendeeName,
            CompanyId = entity.CompanyId.ToString(),
            Link = entity.Link,
            Class = entity.Class,
            Location = entity.Location,
            Type = entity.Type,
            Status = entity.Status,
            Comments = entity.Comments,
            Attendee = entity.Attendee.Select(pr => new AppointmentBookingAttendeesDataModel
            {
                AppointmentBookingAttendeesId = pr.AppointmentBookingAttendeesId,
                AttendeesId = pr.AttendeesId.ToString(),
                AppointmentBookingId = pr.AppointmentBookingId,
            }).ToList()
        };
    }
}