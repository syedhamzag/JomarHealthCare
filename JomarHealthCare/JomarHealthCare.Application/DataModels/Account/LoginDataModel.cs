namespace JomarHealthCare.Application.DataModels.Account;

public class LoginDataModel
{
    public string EmailAddress { get; set; } = default!;
    public string Password { get; set; } = default!;
}



public class AddSuperAdminDataModel
{
    public string Email { get; set; }
    public string Password { get; set; }
}
public class UpdateSuperAdminDataModel
{
    public string Email { get; set; }
}
