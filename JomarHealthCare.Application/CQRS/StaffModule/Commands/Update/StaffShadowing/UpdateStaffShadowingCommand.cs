using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record UpdateStaffShadowingCommand(StaffShadowingDataModel DataModel) : IRequest<bool>;
}