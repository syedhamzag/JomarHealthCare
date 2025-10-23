namespace JomarHealthCare.Domain.Entities
{
    public class Training
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Topic { get; set; }
        public string TrainingURl { get; set; }
        public string Trainer { get; set; }
        public string Remark { get; set; }
        public string Attachment { get; set; }
    }
}
