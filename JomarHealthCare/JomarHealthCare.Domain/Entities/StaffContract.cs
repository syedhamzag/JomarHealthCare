namespace JomarHealthCare.Domain.Entities
{
    public class StaffContract
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public Guid StaffId { get; set; }
        public string Template { get; set; }
        public string StaffSignature { get; set; }
        public DateTime? StaffSignatureDate { get; set; }
        public string HRSignature { get; set; }
        public DateTime? HRSignatureDate { get; set; }
    }
}
