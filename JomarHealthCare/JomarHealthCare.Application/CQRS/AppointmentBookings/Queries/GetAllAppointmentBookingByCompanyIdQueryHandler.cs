using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.AppointmentBookings;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.AppointmentBookings.Queries;


internal class GetAllAppointmentBookingByCompanyIdQueryHandler : IRequestHandler<GetAllAppointmentBookingByIdQuery, List<AppointmentBookingDataModel>>
{
    private readonly IAppointmentBookingRepository _repository;

    public GetAllAppointmentBookingByCompanyIdQueryHandler(IAppointmentBookingRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<AppointmentBookingDataModel>> Handle(GetAllAppointmentBookingByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.CompanyId).Include(x => x.Attendee).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new AppointmentBookingDataModel
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
        }).ToList();
    }
}