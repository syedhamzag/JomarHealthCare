using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffInterviewCommandValidator : AbstractValidator<CreateStaffInterviewCommand>
    {
        public CreateStaffInterviewCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffPersonalInfoId).NotEmpty();
            RuleFor(x => x.DataModel.Heading).NotEmpty();
        }
    }
}