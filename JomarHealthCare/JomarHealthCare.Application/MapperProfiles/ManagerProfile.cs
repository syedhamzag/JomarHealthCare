using AutoMapper;
using JomarHealthCare.Application.DataModels.ExternalUser;
using JomarHealthCare.Application.DataModels.IncidentDetails;
using JomarHealthCare.Application.DataModels.IncidentType;
using JomarHealthCare.Application.DataModels.ReportedConcerns;
using JomarHealthCare.Application.DataModels.WhisttleBlowers;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class ManagerProfile :Profile
    {
        public ManagerProfile()
        {
            CreateMap<ExternalRole, ExternalUserDataModel>()
            // Ensure that Email and Username is not mapped because it's not in ExternalRole
            .ForMember(dest => dest.Email, opt => opt.Ignore())
            .ForMember(dest => dest.Username, opt => opt.Ignore())
            .ReverseMap();

            CreateMap<ExternalRoleAccess, ExternalRoleAccessDataModel>().ReverseMap();
            CreateMap<ExternalRoleAccessClient, ExternalRoleAccessClientDataModel>().ReverseMap();
            CreateMap<ExternalRoleAccessStaff, ExternalRoleAccessStaffDataModel>().ReverseMap();
            CreateMap<IncidentDetail, IncidentDetailDataModel>().ReverseMap();
            CreateMap<IncidentDetailAssignedTo, IncidentDetailAssignedToDataModel>().ReverseMap();
            CreateMap<WhisttleBlower, WhisttleBlowerDataModel>().ReverseMap();
            CreateMap<IncidentType, IncidentTypeDataModel>().ReverseMap();
            CreateMap<ReportedConcern, ReportedConcernDataModel>().ReverseMap();

        }
    }
}
