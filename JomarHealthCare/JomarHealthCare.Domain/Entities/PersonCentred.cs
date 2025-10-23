namespace JomarHealthCare.Domain.Entities
{
    public class PersonCentred
    {
        public int PersonCentredId { get; set; }
        public Guid ClientId { get; set; }
        public int Class { get; set; }
        public string ExpSupport { get; set; }
        public string Focus { get; set; }
        public virtual Client Client { get; set; }
    }
}
