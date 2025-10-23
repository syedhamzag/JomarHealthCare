namespace JomarHealthCare.Domain.Entities
{
    public class CompanyOnlineTraining
    {
        public int Id { get; set; }
        public Guid CompanyId { get; set; }
        public int OnlineTrainingId { get; set; }
    }
}
