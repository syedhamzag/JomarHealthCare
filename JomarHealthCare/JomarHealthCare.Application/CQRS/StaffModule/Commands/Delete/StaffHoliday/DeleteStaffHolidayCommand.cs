using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffHolidayCommand(int Id) : IRequest<bool>;
}