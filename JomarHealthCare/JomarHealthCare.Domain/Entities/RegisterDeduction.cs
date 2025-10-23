namespace JomarHealthCare.Domain.Entities
{
    public class RegisterDeduction
    {
        public int Id { get; set; }
        public string DeductionName { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
