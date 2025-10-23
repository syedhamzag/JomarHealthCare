namespace JomarHealthCare.Domain.Entities
{
    public class OnlineTrainingBundleCourse
    {
        public int Id { get; set; }
        public int OnlineTrainingBundleId { get; set; }
        public int OnlineTrainingId { get; set; }
        public virtual OnlineTraning OnlineTraning { get; set; }
        public virtual OnlineTrainingBundle OnlineTrainingBundle { get; set; }
        public virtual StaffBundleCourseResult StaffBundleCourseResult { get; set; }
    }
}
