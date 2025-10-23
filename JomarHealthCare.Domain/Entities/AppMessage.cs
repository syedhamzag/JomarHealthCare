namespace JomarHealthCare.Domain.Entities
{
    public class AppMessage
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int ToWhom { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool PauseOrStart { get; set; }
    }
}
