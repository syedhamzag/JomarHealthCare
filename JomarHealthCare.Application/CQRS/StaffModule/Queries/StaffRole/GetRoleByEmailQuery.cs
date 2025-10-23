using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public record GetRoleByEmailQuery(string Email) : IRequest<string>;
}
