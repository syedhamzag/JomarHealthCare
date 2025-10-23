using AutoMapper;
using JomarHealthCare.Application.DataModels.client.HospitalEntry;
using JomarHealthCare.Application.DataModels.Client.BestInterest;
using JomarHealthCare.Application.DataModels.Client.DutyOnCall;
using JomarHealthCare.Application.DataModels.Client.HospitalExit;
using JomarHealthCare.Application.DataModels.Client.Infection;
using JomarHealthCare.Application.DataModels.Client.InterestObjective;
using JomarHealthCare.Application.DataModels.Client.InvoiceRate;
using JomarHealthCare.Application.DataModels.Client.Medication;
using JomarHealthCare.Application.DataModels.Client.Nutrition;
using JomarHealthCare.Application.DataModels.Client.Program;
using JomarHealthCare.Application.DataModels.Client.RiskAssessment;
using JomarHealthCare.Application.DataModels.Client.Rotering;
using JomarHealthCare.Application.DataModels.Management;
using JomarHealthCare.Application.DataModels.Pet;
using JomarHealthCare.Application.DataModels.Voice;
using JomarHealthCare.Application.DataModels.Watch;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class ClientMapper : Profile
    {
        public ClientMapper()
        {
            CreateMap<HomeRiskAssessment, HomeRiskAssessmentDataModel>().ReverseMap();
            CreateMap<HomeRiskAssessmentTask, HomeRiskAssessmentDataItemModel>().ReverseMap();
            CreateMap<ClientInvoiceRate, ClientInvoiceRateDataModel>().ReverseMap();


            #region Client Interest and Objective
            CreateMap<InterestAndObjective, ClientInterestAndObjectiveDataModel>().ReverseMap();
            CreateMap<PersonalityTest, PersonalityTestDataModel>().ReverseMap();
            #endregion

            #region Duty on Call
            CreateMap<DutyOnCall, DutyOnCallDataModel>().ReverseMap();
            CreateMap<DutyOnCallPersonResponsible, DutyOnCallPersonResponsibleDataModel>().ReverseMap();
            CreateMap<DutyOnCallPersonToAct, DutyOnCallPersonToActDataModel>().ReverseMap();
            #endregion

            #region Rotering
            CreateMap<RotaDayofWeek, RotaDayofWeekDataModel>().ReverseMap();
            CreateMap<RotaTask, RotaTaskDataModel>().ReverseMap();
            CreateMap<ClientRotaType, ClientRotaTypeDataModel>().ReverseMap();
            CreateMap<Rota, RotaDataModel>().ReverseMap();
            CreateMap<ClientRota, ClientRotaDataModel>().ReverseMap();
            CreateMap<ClientRotaDays, ClientRotaDayDataModel>().ReverseMap();
            CreateMap<ClientRotaTask, ClientRotaTaskDataModel>().ReverseMap();
            #endregion

            #region Client Medication
            CreateMap<ClientMedication, ClientMedicationDataModel>().ReverseMap();
            CreateMap<ClientMedicationDay, ClientMedicationDayDataModel>().ReverseMap();
            CreateMap<ClientMedicationPeriod, ClientMedicationPeriodDataModel>().ReverseMap();
            #endregion

            #region client Program
            CreateMap<ClientProgram, ClientProgramDataModel>().ReverseMap();
            #endregion

            #region Pet
            CreateMap<ClientPetDataModel, Pets>().ReverseMap();
            #endregion

            #region Infection Control
            CreateMap<InfectionControl, ClientInfectionControlDataModel>().ReverseMap();
            #endregion

            #region Service Watch
            CreateMap<ClientServiceWatch, ClientServiceWatchDataModel>().ReverseMap();
            CreateMap<ServiceOfficerToAct, ServiceOfficerToActDataModel>().ReverseMap();
            CreateMap<ServiceStaffName, ServiceStaffNameDataModel>().ReverseMap();
            #endregion

            #region Client Management Visit
            CreateMap<ClientMgtVisit, ClientMgtVisitDataModel>().ReverseMap();
            #endregion

            #region client voice
            CreateMap<ClientVoice, ClientVoiceDataModel>().ReverseMap();
            #endregion

            #region Best Interest Assessment
            CreateMap<BestInterestAssessment, BestInterestDataModel>().ReverseMap();
            #endregion

            #region Client Nutrition
            CreateMap<ClientNutrition, ClientNutritionDataModel>().ReverseMap();
            CreateMap<ClientShopping, ClientShoppingDataModel>().ReverseMap();
            CreateMap<ClientCleaning, ClientCleaningDataModel>().ReverseMap();
            CreateMap<ClientMealDays, ClientMealDaysDataModel>().ReverseMap();
            #endregion

            #region Hospital Entry
            CreateMap<HospitalEntry, HospitalEntryDataModel>().ReverseMap();
            #endregion

            #region Hospital Exist
            CreateMap<HospitalExit, HospitalExitDataModel>().ReverseMap();
            #endregion
        }
    }
}
