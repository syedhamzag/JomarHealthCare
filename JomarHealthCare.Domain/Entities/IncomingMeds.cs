namespace JomarHealthCare.Domain.Entities
{
    public class IncomingMeds
    {
        public int IncomingMedsId { get; set; }
        public DateTime Date { get; set; }
        public Guid UserName { get; set; }
        public string StaffName { get; set; }
        public string StartDate { get; set; }
        public string ChartImage { get; set; }
        public string MedsImage { get; set; }
        public int Status { get; set; }
        public string CreatedBy { get; set; }


       
    }
}
