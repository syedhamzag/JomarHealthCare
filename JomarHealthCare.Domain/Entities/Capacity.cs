namespace JomarHealthCare.Domain.Entities
{
    public class Capacity 
    {
        public int CapacityId { get; set; }
        public Guid ClientId { get; set; }
        public int Pointer { get; set; }
        public int Implication { get; set; }
        public string Indicators { get; set; }
    }
}
