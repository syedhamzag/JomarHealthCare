using MediatR;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands.User
{
    public class CreateApplicationUserCommand : IRequest<ApplicationUser>
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public Guid CompanyId { get; set; }
    }
}