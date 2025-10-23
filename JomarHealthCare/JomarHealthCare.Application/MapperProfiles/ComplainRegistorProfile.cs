using AutoMapper;
using JomarHealthCare.Application.DataModels.Client.DutyOnCall;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.Complaints;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class ComplainRegistorProfile : Profile
    {
        public ComplainRegistorProfile()
        {
            CreateMap<ComplainRegistor, ComplainRegistorDataModel>().ReverseMap();
            CreateMap<ComplainRegistorClients, ComplainRegistorClientDataModel>().ReverseMap();
            CreateMap<ComplainRegistorStaff, ComplainRegistorStaffDataModel>().ReverseMap();
        }
    }
}