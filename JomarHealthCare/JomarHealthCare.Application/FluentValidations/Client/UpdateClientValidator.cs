using FluentValidation;
using JomarHealthCare.Application.CQRS.Client.Commands;

namespace JomarHealthCare.Application.FluentValidations.Client
{
    public class UpdateClientValidator: AbstractValidator<UpdateClientCommand>
    {
        public UpdateClientValidator()
        {
            RuleFor(c => c.ClientId)
            .NotEmpty().WithMessage("ClientId is required.");


            RuleFor(c => c.Lastname)
               .NotEmpty().WithMessage("Lastname required")
               .MaximumLength(100);

            RuleFor(c => c.IDNo)
               .NotEmpty().WithMessage("IDNO required")
               .MaximumLength(100);

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email is required")
                .MaximumLength(100);

            RuleFor(c => c.DateOfBirth)
               .NotEmpty().WithMessage("Date of birth cannot be empty")
               .Must(c => c.Date < DateTime.Now.Date)
               .WithMessage("Date of birth cannot be greater than today");

            RuleFor(c => c.Gender)
               .NotEmpty().WithMessage("Gender is required")
               .MaximumLength(100);
        }
    }
}
