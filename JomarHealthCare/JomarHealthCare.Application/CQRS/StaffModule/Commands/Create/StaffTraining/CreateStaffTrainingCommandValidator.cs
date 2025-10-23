using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffTrainingCommandValidator : AbstractValidator<CreateStaffTrainingCommand>
    {
        public CreateStaffTrainingCommandValidator()
        {
            RuleFor(x => x.DataModel.Training).NotEmpty();
            RuleFor(x => x.DataModel.StartDate).NotEmpty();
        }
    }
}