using AutoMapper;
using JomarHealthCare.Application.DataModels.AppointmentBookings;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class AppointmentBookingProfile : Profile
    {
        public AppointmentBookingProfile()
        {
            CreateMap<AppointmentBooking, AppointmentBookingDataModel>().ReverseMap();
            CreateMap<AppointmentBookingAttendees, AppointmentBookingAttendeesDataModel>().ReverseMap();
        }
    }
}