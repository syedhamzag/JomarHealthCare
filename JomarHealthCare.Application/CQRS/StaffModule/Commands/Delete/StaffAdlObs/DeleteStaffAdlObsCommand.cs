using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffAdlObsCommand(int ObservationID) : IRequest<bool>;




}