namespace JomarHealthCare.Domain.Entities
{
    public class CallDetail
    {
        public int CallDetailId { get; set; }
       
        public int ServiceWeekId { get; set; }
        public string NameOfCaller { get; set; }
        public DateTime DateOfCall { get; set; }
        public DateTime TimeOfCall { get; set; }
        public string FeedBack { get; set; }
        public string Brief { get; set; }


    }
}
