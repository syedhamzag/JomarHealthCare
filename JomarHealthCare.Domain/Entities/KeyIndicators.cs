namespace JomarHealthCare.Domain.Entities
{
    public class KeyIndicators
    {
        public int KeyId { get; set; }
        public Guid ClientId { get; set; }
        public string AboutMe { get; set; }
        public string FamilyRole { get; set; }
        public int LivingStatus { get; set; }
        public int Debture { get; set; }
        public string ThingsILike { get; set; }
        public string LogMethod { get; set; }
    }
}
