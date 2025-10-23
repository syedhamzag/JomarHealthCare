using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record CreateStaffInterviewCommand(StaffInterviewDataModel DataModel) : IRequest<StaffInterviewDataModel>;
}