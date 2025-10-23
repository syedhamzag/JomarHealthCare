using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record CreateStaffTrainingCommand(StaffTrainingDataModel DataModel) : IRequest<StaffTrainingDataModel>;
}