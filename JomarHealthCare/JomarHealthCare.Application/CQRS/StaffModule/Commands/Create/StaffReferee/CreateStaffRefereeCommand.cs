using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record CreateStaffRefereeCommand(StaffRefereeDataModel DataModel) : IRequest<StaffRefereeDataModel>;
}