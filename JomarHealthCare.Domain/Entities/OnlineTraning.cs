namespace JomarHealthCare.Domain.Entities
{
    public class OnlineTraning
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Author { get; set; }
        public int? MaterialId { get; set; }
        public string Video { get; set; }
        public string Attachment { get; set; }
        public int? PassingMarks { get; set; }
        public string CreatedBy { get; set; }
        public bool IsPaid { get; set; }
        public decimal? Fee { get; set; }
        public DateTime? RenewalDate { get; set; }
        public bool IsHasLogQuestion { get; set; }
        public string PaymentURL { get; set; }
        public string StripePaymentLinkId { get; set; }
        public string StripeProductId { get; set; }
        public string AuthorSignature { get; set; }
        public OnlineTrainingEnum TrainingType { get; set; }
        public virtual OnlineClass Class { get; set; }
        public virtual OnlineMaterialType Material { get; set; }

        public virtual ICollection<OnlineTraningQuestion> OnlineTraningQuestion { get; set; }
        public virtual ICollection<OnlineTraininglogQuestion> OnlineTraininglogQuestion { get; set; }
    }
}
