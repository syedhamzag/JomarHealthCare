
namespace JomarHealthCare.Domain.Entities;

public class ClientFacilityRisk : AuditableEntity,ICompanyEntity
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public string Attachment { get; set; }
    public int FacilityClientId { get; set; }
    public int TypeId { get; set; }
    public ClientFacility ClientFacility { get; set; }
    public Guid? CompanyId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Company? Company { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
