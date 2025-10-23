namespace JomarHealthCare.Domain.Entities
{
    public class ContractTemplate
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string Template { get; set; }
        public int JobPositionId { get; set; }
        public string CreatedBy { get; set; }
    }
}
