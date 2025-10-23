namespace JomarHealthCare.Domain.Entities
{
    public class DeductionForAllStaff
    {
        public DeductionForAllStaff() {
            DeductionValue = new HashSet<DeductionValue>();

        }
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<DeductionValue> DeductionValue { get; set; }

    }
}
