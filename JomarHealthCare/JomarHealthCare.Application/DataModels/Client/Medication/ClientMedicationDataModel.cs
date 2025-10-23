namespace JomarHealthCare.Application.DataModels.Client.Medication;

public class GetClientMedicationDataModel
{
    public int ClientMedicationId { get; set; }
    public int? MedicationId { get; set; }
    public string Medication { get; set; }
    public string medicationManufacturer { get; set; }
    public int? MedicationManufacturerId { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string Dossage { get; set; }
    public string Frequency { get; set; }
    public int? Gap_Hour { get; set; }
    public string Route { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? StopDate { get; set; }
    public string Status { get; set; }
    public string Remark { get; set; }
    public string PRNGuideline { get; set; }
    public int? Means { get; set; }
    public int? Type { get; set; }
    public int? TimeCritical { get; set; }
    public int? MedicationRouteId { get; set; }
    public string ClientMedImage { get; set; }
    public bool IsPause { get; set; }
    public bool IsDelete { get; set; }
    public List<ClientMedicationDayDataModel> ClientMedicationDay { get; set; }
    public Guid? ClientId { get; set; }
}

public class ClientMedicationDataModel
{
    public int ClientMedicationId { get; set; }
    public int? MedicationId { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string Dossage { get; set; }
    public string Frequency { get; set; }
    public int? Gap_Hour { get; set; }
    public string Route { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? StopDate { get; set; }
    public string Status { get; set; }
    public string Remark { get; set; }
    public string PRNGuideline { get; set; }
    public int? Means { get; set; }
    public int? Type { get; set; }
    public int? TimeCritical { get; set; }
    public int? MedicationRouteId { get; set; }
    public string ClientMedImage { get; set; }
    public bool IsPause { get; set; }
    public bool IsDelete { get; set; }
    public List<ClientMedicationDayDataModel> ClientMedicationDay { get; set; }
    public Guid? ClientId { get; set; }
}


public class ClientMedicationDayDataModel
{
    public int ClientMedicationDayId { get; set; }
    public int RotaDayofWeekId { get; set; }
    public int ClientMedicationId { get; set; }
    public List<ClientMedicationPeriodDataModel> ClientMedicationPeriod { get; set; }
}

public class ClientMedicationPeriodDataModel
{
    public int ClientMedicationPeriodId { get; set; }
    public int? ClientRotaTypeId { get; set; }
    public int? ClientMedicationDayId { get; set; }
    public int? RotaId { get; set; }
    public string StartTime { get; set; }
    public string StopTime { get; set; }
    public bool MedLiveTrackerDelete { get; set; }
}