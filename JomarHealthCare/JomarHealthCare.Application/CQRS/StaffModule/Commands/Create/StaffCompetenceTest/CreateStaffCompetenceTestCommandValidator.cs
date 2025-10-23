using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffCompetenceTestCommandValidator : AbstractValidator<CreateStaffCompetenceTestCommand>
    {
        public CreateStaffCompetenceTestCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffPersonalInfoId).NotEmpty();
            RuleFor(x => x.DataModel.Heading).NotEmpty();
        }
    }
}