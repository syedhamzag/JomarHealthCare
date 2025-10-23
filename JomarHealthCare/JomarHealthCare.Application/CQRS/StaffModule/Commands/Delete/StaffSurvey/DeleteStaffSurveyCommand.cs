using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffSurveyCommand(int Id) : IRequest<bool>;
}