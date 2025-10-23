using AutoMapper;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles;

public class CareplanMapper : Profile
{
    public CareplanMapper()
    {
        CreateMap<PersonCentred, PersonCentredModelData>().ReverseMap();
        CreateMap<ClientKeyworkerNotes, KeyworkerDataModel>().ReverseMap();
        CreateMap<Review, ReviewDataModel>().ReverseMap();
        CreateMap<KeyIndicators, KeyIndicatorDataModel>().ReverseMap();
        CreateMap<Capacity, CapacityDataModel>().ReverseMap();
        CreateMap<Personal, PersonalDataModel>().ReverseMap();
        CreateMap<BodyMap, BodyMapDataModel>().ReverseMap();
        CreateMap<CarePlanNutrition, CarePlanNutritionDataModel>().ReverseMap();
        CreateMap<HealthAndLiving, HealthAndLivingDataModel>().ReverseMap();
        CreateMap<Balance, BalanceDataModel>().ReverseMap();
        CreateMap<PhysicalAbility, PhysicalAbilityDataModel>().ReverseMap();
        CreateMap<HistoryOfFall, HistoryOfFallDataModel>().ReverseMap();
        CreateMap<ClientCongnitive, CongnitiveDataModel>().ReverseMap();
        CreateMap<SpecialHealthAndMedication, SpecialHealthAndMedicationDataModel>().ReverseMap();
        CreateMap<PersonalHygiene, PersonalHygieneDataModel>().ReverseMap();
        CreateMap<OralCare, OralCareDataModel>().ReverseMap();
        CreateMap<MentalHealthSupport, MentalHealthSupportDataModel>().ReverseMap();
        CreateMap<ConsentData, ConsentDataModel>().ReverseMap();
    }
}
