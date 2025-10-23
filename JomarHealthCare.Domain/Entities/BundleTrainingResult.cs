namespace JomarHealthCare.Domain.Entities
{
    public class BundleTrainingResult
    {
        public int Id { get; set; }
        public int BundleId { get; set; }
        public Guid StaffId { get; set; }
        public int TrainingId { get; set; }
        public string Status { get; set; }
    }
}
