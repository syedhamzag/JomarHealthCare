
namespace JomarHealthCare.Domain.Entities
{
    public class ClientMealType : AuditableEntity, ICompanyEntity
    {
        public int ClientMealTypeId { get; set; }
        public string MealType { get; set; }

        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
