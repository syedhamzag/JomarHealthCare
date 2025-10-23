using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace JomarHealthCare.Application.DataModels.SendRota;

public class MedTrackerDataModel
{
    public MedTrackerDataModel()
    {
        UpdateMedicationPeriod = new List<GetClientMedicationAdditional>();
    }
    public string PERIOD { get; set; }
    public DateTime RotaDate { get; set; }
    public string RotaName { get; set; }
    public string ClientName { get; set; }
    public DateTime? DOB { get; set; }
    public string PostCode { get; set; }
    public string ClientIdNumber { get; set; }
    public int ClientMedicationId { get; set; }
    public Guid? ClientId { get; set; }
    public int? MedicationId { get; set; }
    public int? MedicationManufacturerId { get; set; }
    public string Medication { get; set; }
    public string MedicationManufacturer { get; set; }
    public string Strength { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string Dossage { get; set; }
    public string Frequency { get; set; }
    public int? Gap_Hour { get; set; }
    public string Route { get; set; }
    public string StartDate { get; set; }
    public string StopDate { get; set; }
    public string Status { get; set; }
    public string Remark { get; set; }
    public int? Means { get; set; }
    public string MeansValue { get; set; }
    public int? Type { get; set; }
    public int? TimeCritical { get; set; }
    public string ClientMedImage { get; set; }
    public string StaffName { get; set; }
    public int? NoOfStaff { get; set; }
    public string DoseGiven { get; set; }
    public string Time { get; set; }
    public string Measurement { get; set; }
    public string Location { get; set; }
    public string Feedback { get; set; }
    public bool GivenToRightPerson { get; set; }
    public bool GivenRightPersonTime { get; set; }
    public bool ConfirmRightDoseGiven { get; set; }
    public bool ConfirmMedicationRoute { get; set; }
    public string ClockInLocation { get; set; }
    public string ClockOutLocation { get; set; }
    public DateTimeOffset? ClockInTime { get; set; }
    public DateTimeOffset? ClockOutTime { get; set; }
    public string DosePrescribed { get; set; }
    public string StaffCommentsOrConcern { get; set; }
    public string GivenMedicationNotInChart { get; set; }
    public string Attachment { get; set; }
    public bool Certify { get; set; }
    public string AuditRemarks { get; set; }
    public string ActionRecommendation { get; set; }
    public bool ContactEstablishedWithGP { get; set; }
    public string StateDisuccGP { get; set; }
    public string EvidenceOfActionTaken { get; set; }
    public string AuditStatus { get; set; }
    public string NameOfAuditor { get; set; }
    public DateTime? DateOfAudit { get; set; }
    public bool EmailAuditToClient { get; set; }
    public bool EmailAuditToStaff { get; set; }
    public bool ConcernWithStaff { get; set; }
    public bool ConcertWithClient { get; set; }
    public int StaffRotaId { get; set; }
    public int? StaffRotaAuditId { get; set; }
    public int? AuditorId { get; set; }
    public int? AuditId { get; set; }

    [DataType(DataType.Upload)]

    public IFormFile Evidence { get; set; }

    public string periodStart { get; set; }
    public string periodEnd { get; set; }
    public int ClientMedicationPeriodId { get; set; }
    public string color { get; set; }
    public int StaffId { get; set; }
    public string selectedStaff { get; set; }
    public string selectedClient { get; set; }
    public int? SummaryId { get; set; }
    public int RotaDayofWeekId { get; set; }
    public int ClientRotaTypeId { get; set; }

    public List<StaffName> SName { get; set; }

    public List<GetClientMedicationAdditional> UpdateMedicationPeriod { get; set; }
}


public class StaffName
{
    public string Name { get; set; }
    public string InitialName { get; set; }
    public string Signature { get; set; }
}

public class GetClientMedicationAdditional
{
    public int Id { get; set; }
    public int ClientMedicationPeriodId { get; set; }
    public string DoseTobeGiven { get; set; }
    public string DoseGiven { get; set; }
    public string Instruction { get; set; }
    public string FeedBack { get; set; }
    public string RotaDate { get; set; }
    public TimeSpan? Time { get; set; }
    public TimeSpan? StopTime { get; set; }
    public string Status { get; set; }
}