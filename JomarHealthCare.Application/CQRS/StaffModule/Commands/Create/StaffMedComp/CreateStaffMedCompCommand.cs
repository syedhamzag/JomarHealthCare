using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record CreateStaffMedCompCommand(StaffMedCompDataModel DataModel) : IRequest<StaffMedCompDataModel>;
}