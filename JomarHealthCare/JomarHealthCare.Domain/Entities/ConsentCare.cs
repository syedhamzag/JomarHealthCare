namespace JomarHealthCare.Domain.Entities
{
    public class ConsentCare
    {
        public int CareId { get; set; }
        public int PersonalDetailId { get; set; }
        public int Signature { get; set; }
        public DateTime Date { get; set; }
        public int Name { get; set; }

        public virtual PersonalDetail PersonalDetail { get; set; }
    }
}
