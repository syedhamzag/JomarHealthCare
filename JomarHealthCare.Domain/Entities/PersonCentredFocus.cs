namespace JomarHealthCare.Domain.Entities
{
    public class PersonCentredFocus
    {
        public int PersonCentredFocusId { get; set; }
        public int PersonCentredId { get; set; }
        public int BaseRecordId { get; set; }

        public virtual PersonCentred PersonCentre { get; set; }
    }
}
