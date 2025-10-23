using AutoMapper;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class OneToOneOfficerToActProfile : Profile
    {
        public OneToOneOfficerToActProfile()
        {
            CreateMap<OneToOneOfficerToAct, OneToOneOfficerToActDataModel>().ReverseMap();
        }
    }
}