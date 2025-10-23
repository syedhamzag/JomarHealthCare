using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record StaffPersonalInfoCommand(OnboardStaffDataModel DataModel) : IRequest<OnboardStaffDataModel>;
}