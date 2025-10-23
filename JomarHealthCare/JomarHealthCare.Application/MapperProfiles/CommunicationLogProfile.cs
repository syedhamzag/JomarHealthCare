using AutoMapper;
using JomarHealthCare.Application.DataModels.Client.TaskBoard;
using JomarHealthCare.Application.DataModels.CommunicationLogs;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class CommunicationLogProfile : Profile
    {
        public CommunicationLogProfile()
        {
            CreateMap<CommunicationLog, CommunicationLogDataModel>()
                .ForMember(s => s.Time, opt => opt.MapFrom(src => TimeOnly.FromDateTime(src.Time)));
            CreateMap<CommunicationLogDataModel, CommunicationLog>()
                .ForMember(dest => dest.Time, opt => opt.MapFrom(src => DateTime.Today.Add(src.Time.ToTimeSpan())));
            CreateMap<CommunicationLogAttendees, CommunicationLogAttendeesDataModel>().ReverseMap();
            CreateMap<CommunicationLogApologies, CommunicationLogApologiesDataModel>().ReverseMap();
        }
    }
}