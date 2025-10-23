using FluentValidation;
using JomarHealthCare.Application.CQRS.Client.Commands;

namespace JomarHealthCare.Application.FluentValidations.Client
{
    public class CreateClientValidator: AbstractValidator<CreateClientCommand>
    {
        public CreateClientValidator()
        {
            RuleFor(c => c.Firstname)
             .NotEmpty().WithMessage("Firstname is required.")
             .MaximumLength(100);

            RuleFor(c => c.IdNumber)
               .NotEmpty().WithMessage("IDNO required")
               .MaximumLength(100);

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email is required")
                .MaximumLength(100);

            RuleFor(c => c.DateOfBirth)
               .NotEmpty().WithMessage("Date of birth cannot be empty")
               .Must(c => c.Date < DateTime.Now.Date)
               .WithMessage("Date of birth cannot be greater than today");

        }
    }
}
