namespace JomarHealthCare.Domain.Entities
{
    public class ConsentLandLine
    {
        public ConsentLandLine()
        {
            LogMethod = new HashSet<ConsentLandlineLog>();
        }
        
        public int LandlineId { get; set; }
        public int PersonalDetailId { get; set; }
        public int Name { get; set; }
        public int Signature { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<ConsentLandlineLog> LogMethod { get; set; }

        public virtual PersonalDetail PersonalDetail { get; set; }
    }
}
