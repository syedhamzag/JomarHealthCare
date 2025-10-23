using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.ExternalUser;

public class ExternalRoleAccessDataModel
{
    public int ExternalAccessId { get; set; }
    public List<ExternalRoleAccessStaffDataModel> Staff { get; set; }
    public List<ExternalRoleAccessClientDataModel> Client { get; set; }
    public int ExternalId { get; set; }
    public string ExternalName { get; set; }
    public string CreatedBy { get; set; }
}
public class ExternalRoleAccessStaffDataModel
{
    public int ExternalRoleAccessStaffId { get; set; }
    public int ExternalAccessId { get; set; }
    public string StaffPersonalInfoId { get; set; }
    public string StaffName { get; set; }
}
public class ExternalRoleAccessClientDataModel
{
    public int ExternalRoleAccessClientId { get; set; }
    public int ExternalAccessId { get; set; }
    public string ClientId { get; set; }
    public string ClientName { get; set; }
}
