namespace JomarHealthCare.Domain.Entities
{
    public class Enotice
    {
        public Guid EnoticeId { get; set; }
        public DateTime Date { get; set; }
        public Guid PublishTo { get; set; }
        public string Heading { get; set; }
        public string Note { get; set; }
        public Guid PublishBy { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }

       
    }
}
