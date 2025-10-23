using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record CreateStaffSurveyCommand(StaffSurveyDataModel DataModel) : IRequest<StaffSurveyDataModel>;
}