namespace JomarHealthCare.Domain.Entities
{
    public class RegisterIncome
    {
        public int Id { get; set; }
        public string IncomeName { get; set; }
        public Guid? CompanyId { get; set; }

    }
}
