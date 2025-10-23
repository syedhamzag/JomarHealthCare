using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffEmergencyContactCommand(int Id) : IRequest<bool>;







}