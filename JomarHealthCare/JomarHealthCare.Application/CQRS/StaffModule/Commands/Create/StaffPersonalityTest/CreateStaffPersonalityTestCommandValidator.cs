using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffPersonalityTestCommandValidator : AbstractValidator<CreateStaffPersonalityTestCommand>
    {
        public CreateStaffPersonalityTestCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffPersonalInfoId).NotEmpty();
            RuleFor(x => x.DataModel.Answer).NotEmpty();
            RuleFor(x => x.DataModel.Question).NotEmpty();
        }
    }
}