namespace JomarHealthCare.Domain.Entities
{
    public class DeductionValue
    {
        public int Id { get; set; }
        public int DeductionForAllStaffId { get; set; }
        public int DeductionType { get; set; }
        public int DeductionAmount { get; set; }
        public virtual DeductionForAllStaff DeductionForAllStaff { get; set; }

    }
}
