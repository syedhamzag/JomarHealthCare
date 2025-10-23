using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands.User
{
    public class CreateApplicationUserCommandValidator : AbstractValidator<CreateApplicationUserCommand>
    {
        public CreateApplicationUserCommandValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.CompanyId).NotEmpty();
        }
    }
}