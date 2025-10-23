using AutoMapper;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class StaffMapperProfile : Profile
    {
        public StaffMapperProfile()
        {
            CreateMap<OnboardStaffDataModel, StaffPersonalInfo>().ReverseMap();
            CreateMap<StaffEducation, StaffEducationDataModel>().ReverseMap();
            CreateMap<StaffPersonalInfo, StaffPersonalInfoDataModel>();
            CreateMap<StaffPersonalInfoDataModel, StaffPersonalInfo>();
            CreateMap<StaffReferee, StaffRefereeDataModel>().ReverseMap();
            CreateMap<StaffAdlObs, StaffAdlObsDataModel>().ReverseMap();
            CreateMap<StaffContract, StaffContractDataModel>().ReverseMap();
            CreateMap<StaffHealth, StaffHealthDataModel>().ReverseMap();
            CreateMap<StaffReferee, StaffRefereeDataModel>().ReverseMap();
            CreateMap<StaffHoliday, StaffHolidayDataModel>().ReverseMap();
            CreateMap<StaffSpotCheck, StaffSpotCheckDataModel>().ReverseMap();
            CreateMap<StaffSurvey, StaffSurveyDataModel>().ReverseMap();
            CreateMap<StaffEmergencyContact, StaffEmergencyContactDataModel>().ReverseMap();
            CreateMap<StaffWorkTeam, StaffWorkTeamDataModel>().ReverseMap();
            CreateMap<ClassOfStaff, ClassOfStaffDataModel>().ReverseMap();
            CreateMap<StaffTraining, StaffTrainingDataModel>().ReverseMap();
            CreateMap<StaffInterview, StaffInterviewDataModel>().ReverseMap();
            CreateMap<StaffInterviewTask, StaffInterviewTaskDataModel>().ReverseMap();
            CreateMap<StaffMedComp, StaffMedCompDataModel>().ReverseMap();
            CreateMap<StaffKeyWorkerVoice, StaffKeyWorkerVoiceDataModel>().ReverseMap();
            CreateMap<StaffOneToOne, StaffOneToOneDataModel>().ReverseMap();
            CreateMap<StaffSupervisionAppraisal, StaffSupervisionAppraisalDataModel>().ReverseMap();
            CreateMap<StaffInfectionControl, StaffInfectionControlDataModel>().ReverseMap();
            CreateMap<StaffPersonalityTest, StaffPersonalityTestDataModel>().ReverseMap();
            CreateMap<StaffCompetenceTest, StaffCompetenceTestDataModel>().ReverseMap();
            CreateMap<StaffShadowing, StaffShadowingDataModel>().ReverseMap();
            CreateMap<StaffTrainingByList, StaffTrainingByListDataModel>().ReverseMap();
        }
    }
}