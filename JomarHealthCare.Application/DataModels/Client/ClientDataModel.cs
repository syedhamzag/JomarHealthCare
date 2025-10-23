using JomarHealthCare.Application.DataModels.Client.ClientHobbies;
using JomarHealthCare.Application.DataModels.Client.EquipmentDevices;
using JomarHealthCare.Application.DataModels.Client.HealthCondition;
using JomarHealthCare.Domain.Enums;

namespace JomarHealthCare.Application.DataModels.Client;

public class ClientDataModel
{
    public Guid ClientId { get; set; }
    public string Firstname { get; set; }
    public string Middlename { get; set; }
    public string Surname { get; set; }
    public string ProfileImage { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string UniqueId { get; set; }
    public string PreferredName { get; set; }
    public string ManagerName { get; set; }
}



public class ClientDetailDataModel
{
    public Guid ClientId { get; set; }
    public Guid? CompanyId { get; set; }
    public string Pin { get; set; }
    public string Firstname { get; set; }
    public string Middlename { get; set; }
    public string Surname { get; set; }
    public string PreferredName { get; set; }
    public string Email { get; set; }
    public string About { get; set; }
    public string Hobbies { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Keyworker { get; set; }
    public string IdNumber { get; set; }
    public string Gender { get; set; }
    public int? NumberOfCalls { get; set; }
    public string AreaCode { get; set; }
    public string Territory { get; set; }
    public string ServiceType { get; set; }
    public string ProvisionVenue { get; set; }
    public string PostCode { get; set; }
    public decimal? Rate { get; set; }
    public string TeamLeader { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string Telephone { get; set; }
    public string Language { get; set; }
    public string KeySafe { get; set; }
    public string ChoiceOfStaff { get; set; }
    public string Capacity { get; set; }
    public string ProviderReference { get; set; }
    public int? NumberOfStaff { get; set; }
    public string UniqueId { get; set; }
    public string ProfileImage { get; set; }
    public string Address { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string ClientManager { get; set; }
    public string Denture { get; set; }
    public string Aid { get; set; }
    public double? LocationDistance { get; set; }
    public int? TimeMonitorLower { get; set; }
    public int? TimeMonitorHigher { get; set; }
    public string PracticalSupport { get; set; }
    public string CallGap { get; set; }
    public bool IsDelete { get; set; }
    public bool IsFacilityClient { get; set; }

    public List<ClientHobbiesDataModel> ClientHobbies { get; set; }
    public List<ClientHealthConditionDataModel> GetClientHealthCondition { get; set; }

    public List<ClientEquipmentDeviceDataModel> GetEquipmentAssessment { get; set; }
}


public class UpdateClientDataModel
{
    public string data { get; set; }
}

public class ClientForUpdateDataModel
{
    public Guid ClientId { get; set; }
    public Guid? CompanyId { get; set; }
    public string Pin { get; set; }
    public string Firstname { get; set; }
    public string Middlename { get; set; }
    public string Surname { get; set; }
    public string PreferredName { get; set; }
    public string Email { get; set; }
    public string About { get; set; }
    public string Hobbies { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string KeyworkerId { get; set; }
    public string IdNumber { get; set; }
    public string Gender { get; set; }
    public int? NumberOfCalls { get; set; }
    public int? AreaCodeId { get; set; }
    public int? TeritoryId { get; set; }
    public string ServiceType { get; set; }
    public string ProvisionVenue { get; set; }
    public string PostCode { get; set; }
    public decimal? Rate { get; set; }
    public string TeamLeaderId { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string Telephone { get; set; }
    public string Language { get; set; }
    public string KeySafe { get; set; }
    public string ChoiceOfStaff { get; set; }
    public ClientStatusEnum StatusId { get; set; }
    public string Capacity { get; set; }
    public string ProviderReference { get; set; }
    public int? NumberOfStaff { get; set; }
    public string UniqueId { get; set; }
    public string ProfileImage { get; set; }
    public string Address { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string ClientManagerId { get; set; }
    public string Denture { get; set; }
    public string Aid { get; set; }
    public double? LocationDistance { get; set; }
    public int? TimeMonitorLower { get; set; }
    public int? TimeMonitorHigher { get; set; }
    public string PracticalSupport { get; set; }
    public string CallGap { get; set; }
    public bool IsDelete { get; set; }
    public bool IsFacilityClient { get; set; }
}