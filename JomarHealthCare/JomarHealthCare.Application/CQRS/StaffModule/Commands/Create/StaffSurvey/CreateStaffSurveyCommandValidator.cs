using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffSurveyCommandValidator : AbstractValidator<CreateStaffSurveyCommand>
    {
        public CreateStaffSurveyCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffId).NotEmpty();
            RuleFor(x => x.DataModel.Date).NotEmpty();
            RuleFor(x => x.DataModel.NextCheckDate).NotEmpty();
            RuleFor(x => x.DataModel.Status).GreaterThanOrEqualTo(0);
        }
    }
}