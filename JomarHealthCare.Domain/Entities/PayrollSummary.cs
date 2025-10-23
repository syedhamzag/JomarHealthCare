namespace JomarHealthCare.Domain.Entities
{
    public class PayrollSummary
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid CompanyId { get; set; }
        public int? CategoryofStaff { get; set; }
        public int? TypeofStaffService { get; set; }
        public int? StaffClass { get; set; }
        public string Staff { get; set; }
    }
}
