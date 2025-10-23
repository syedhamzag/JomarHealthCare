using MediatR;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public record DeleteStaffSpotCheckCommand(int Id) : IRequest<bool>;
}
