using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands.User
{
    public class DeleteApplicationUserCommand : IRequest<Unit>
    {
        public string Id { get; set; }
    }
}