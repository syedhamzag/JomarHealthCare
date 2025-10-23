using AutoMapper;
using JomarHealthCare.Application.DataModels.HumanResourcesModule;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class OfficeAttendanceProfile : Profile
    {
        public OfficeAttendanceProfile()
        {
            CreateMap<OfficeAttendance, OfficeAttendanceDataModel>().ReverseMap();
        }
    }
}