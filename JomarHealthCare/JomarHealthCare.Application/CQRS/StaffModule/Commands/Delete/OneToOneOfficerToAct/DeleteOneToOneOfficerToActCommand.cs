using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteOneToOneOfficerToActCommand(int Id) : IRequest<bool>;
}