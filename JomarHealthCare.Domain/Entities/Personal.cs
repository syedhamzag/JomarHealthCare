namespace JomarHealthCare.Domain.Entities
{
    public class Personal
    {
        public int PersonalId { get; set; }
        public Guid ClientId { get; set; }
        public string Religion { get; set; }
        public string Nationality { get; set; }
        public int Smoking { get; set; }
        public int DNR { get; set; }
    }
}
