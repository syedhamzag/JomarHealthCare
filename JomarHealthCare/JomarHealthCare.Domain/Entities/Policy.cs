namespace JomarHealthCare.Domain.Entities
{
    public class Policy
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string PolicyName { get; set; }
        public string PolicyURl { get; set; }
        public string Remark { get; set; }
        public string Attachment { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
