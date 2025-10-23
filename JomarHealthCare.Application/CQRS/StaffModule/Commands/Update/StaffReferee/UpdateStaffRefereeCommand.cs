using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record UpdateStaffRefereeCommand(StaffRefereeDataModel DataModel) : IRequest<bool>;
}