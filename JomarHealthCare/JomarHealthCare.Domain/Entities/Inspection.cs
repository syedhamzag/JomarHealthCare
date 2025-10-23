namespace JomarHealthCare.Domain.Entities
{
    public class Inspection
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string FileName { get; set; }
        public string FileURl { get; set; }
        public string Remark { get; set; }
        public string Attachment { get; set; }
    }
}
