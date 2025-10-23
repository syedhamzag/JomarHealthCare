namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffSurveyDataModel
    {
        public int StaffSurveyId { get; set; }
        public string Reference { get; set; }
        public Guid StaffId { get; set; }
        public DateTime Date { get; set; }
        public DateTime NextCheckDate { get; set; }
        public string Details { get; set; }
        public int AdequateTrainingReceived { get; set; }
        public int HealthCareServicesSatisfaction { get; set; }
        public int SupportFromCompany { get; set; }
        public int CompanyManagement { get; set; }
        public int AccessToPolicies { get; set; }
        public string WorkEnvironmentSuggestions { get; set; }
        public string AreaRequiringImprovements { get; set; }
        public string ActionRequired { get; set; }
        public DateTime Deadline { get; set; }
        public int Status { get; set; }
        public string Remarks { get; set; }
        public string URL { get; set; }
        public string Attachment { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
    }
}