using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands.User
{
    public class UpdateApplicationUserCommand : IRequest<string>
    {
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public Guid CompanyId { get; set; }
    }
}