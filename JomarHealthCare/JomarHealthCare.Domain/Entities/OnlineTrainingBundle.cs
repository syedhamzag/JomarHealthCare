namespace JomarHealthCare.Domain.Entities
{
    public class OnlineTrainingBundle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Fee { get; set; }
        public bool IsPaid { get; set; }
        public string StripePaymentLinkId { get; set; }
        public string StripeProductId { get; set; }
        public OnlineTrainingEnum TrainingType { get; set; }
        public string CreatedBy { get; set; }
        public virtual ICollection<OnlineTrainingBundleCourse> OnlineTrainingBundleCourse { get; set; }
    }
}
