namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffAdlObsDataModel
    {
        public int ObservationID { get; set; }
        public string Reference { get; set; }
        public Guid StaffId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? NextCheckDate { get; set; }
        public string Details { get; set; }
        public int UnderstandingofEquipment { get; set; }
        public int UnderstandingofService { get; set; }
        public int UnderstandingofControl { get; set; }
        public int FivePrinciples { get; set; }
        public string Comments { get; set; }
        public string ActionRequired { get; set; }
        public DateTime Deadline { get; set; }
        public int Status { get; set; }
        public string Remarks { get; set; }
        public string URL { get; set; }
        public string Attachment { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
        public Guid? CompanyId { get; set; }
    }
}