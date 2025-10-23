using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateClassOfStaffCommandValidator : AbstractValidator<CreateClassOfStaffCommand>
    {
        public CreateClassOfStaffCommandValidator()
        {
            RuleFor(x => x.DataModel.ClassName).NotEmpty();
        }
    }
}