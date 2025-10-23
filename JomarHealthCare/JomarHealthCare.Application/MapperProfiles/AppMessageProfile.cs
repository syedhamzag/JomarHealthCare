using AutoMapper;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.AppMessage;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class AppMessageProfile : Profile
    {
        public AppMessageProfile()
        {
            CreateMap<AppMessage, AppMessageDataModel>().ReverseMap();
        }
    }
}