namespace JomarHealthCare.Application.Abstractions
{
    public interface IUserIdentityService
    {
        string EmailAddress { get; }
        string SubjectId { get; }
        string PhoneNumber { get; }
        Guid CompanyId { get; }
    }
}
