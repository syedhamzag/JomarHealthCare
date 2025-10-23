using FluentValidation;
using JomarHealthCare.Application.CQRS.Account.Commands;

namespace JomarHealthCare.Application.FluentValidations.Account
{
    public class LoginValidator:AbstractValidator<LoginCommand>
    {
        public LoginValidator()
        {
            RuleFor(c => c.DataModel.EmailAddress)
                .EmailAddress()
                .NotEmpty();

            RuleFor(c => c.DataModel.Password)
                .NotEmpty();
        }
    }
}
