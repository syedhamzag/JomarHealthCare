namespace JomarHealthCare.Domain.Entities
{
    public class StaffBundleCourseResult
    {
        public int Id { get; set; }
        public int BundleId { get; set; }
        public int TrainingCourseId { get; set; }
        public Guid StaffId { get; set; }
        public decimal? ObtainMarks { get; set; }
        public bool IsEligibleForTest { get; set; }
        public string Status { get; set; }
    }
}
