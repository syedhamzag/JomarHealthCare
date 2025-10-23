using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record CreateStaffHealthCommand(StaffHealthDataModel DataModel) : IRequest<StaffHealthDataModel>;
}