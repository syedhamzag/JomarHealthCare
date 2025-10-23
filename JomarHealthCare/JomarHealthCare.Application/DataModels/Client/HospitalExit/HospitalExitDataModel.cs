namespace JomarHealthCare.Application.DataModels.Client.HospitalExit;

public class HospitalExitDataModel
{
    public int HospitalExitId { get; set; }
    public string Reference { get; set; }
    public DateTime? DateAndTime { get; set; }
    public int? ConditionOnDischarge { get; set; }
    public int? NumberOfStaffRequiredOnDischarge { get; set; }
    public int? IsGrosSriesAvaible { get; set; }
    public int? IsHomeCleaned { get; set; }
    public int IsMedicationAvaialable { get; set; }
    public int? IsServiceUseronRota { get; set; }
    public int? isRotaTeamInformed { get; set; }
    public int? isLittleCashAvailableForServiceUser { get; set; }
    public int? ModeOfMeansOfTrasportBackHome { get; set; }
    public int? AreEqipmentNeededAvailable { get; set; }
    public int? AreStaffTrainnedOnEquipmentNeeded { get; set; }
    public int? AreContinentProductNeedAndAvailable { get; set; }
    public int? AreLocalSupportOrProgramNeeded { get; set; }
    public string WhichSupportIsNeeded { get; set; }
    public int? IsCarePlanUpdated { get; set; }
    public int? ReablementRequired { get; set; }
    public string Remark { get; set; }
    public int? Status { get; set; }
    public bool IsDeleted { get; set; }
    public string StaffSignature { get; set; }
    public string OfficerToTakeAction { get; set; }
    public Guid? ClientId { get; set; }
}
