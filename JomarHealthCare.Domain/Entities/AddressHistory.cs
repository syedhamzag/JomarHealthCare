namespace JomarHealthCare.Domain.Entities
{
    public class AddressHistory
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string NoOfLandlord { get; set; }
        public string LandLordContactNumber { get; set; }
        public string Remarks { get; set; }
        public Guid StaffId { get; set; }
    }
}
