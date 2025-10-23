using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record CreateStaffTrainingByListCommand(StaffTrainingByListDataModel DataModel) : IRequest<StaffTrainingByListDataModel>;
    public record DeleteStaffTrainingByListCommand(int StaffTrainingByListId) : IRequest<bool>;
    public record UpdateStaffTrainingByListCommand(StaffTrainingByListDataModel DataModel) : IRequest<bool>;
}