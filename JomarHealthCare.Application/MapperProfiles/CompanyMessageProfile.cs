using AutoMapper;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.CompanyMessage;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class CompanyMessageProfile : Profile
    {
        public CompanyMessageProfile()
        {
            CreateMap<CompanyMessage, CompanyMessageDataModel>().ReverseMap();
        }
    }
}