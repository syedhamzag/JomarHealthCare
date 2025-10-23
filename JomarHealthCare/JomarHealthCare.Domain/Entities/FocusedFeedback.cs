namespace JomarHealthCare.Domain.Entities
{
    public class FocusedFeedback
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Topic { get; set; }
        public string FileURl { get; set; }
        public string Reason { get; set; }
        public string Remark { get; set; }
        public string ConductedBy { get; set; }
    }
}
