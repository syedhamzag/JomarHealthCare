namespace JomarHealthCare.Domain.Entities
{
    public class OnlineTrainingBundleAssignStaff
    {
        public int Id { get; set; }
        public int OnlineTrainingBundleId { get; set; }
        public Guid StaffId { get; set; }
        public DateTime? Date { get; set; }
        public int? NoOfCompleteCourse { get; set; }
        public string Status { get; set; }
        public bool EligibleForTest { get; set; }
        public string PaymentEvidence { get; set; }
        public string Comments { get; set; }
    }
}
