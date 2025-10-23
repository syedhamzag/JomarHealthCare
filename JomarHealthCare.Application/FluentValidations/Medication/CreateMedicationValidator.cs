using FluentValidation;
using JomarHealthCare.Application.CQRS.Medications.Commands;

namespace JomarHealthCare.Application.FluentValidations.Medication
{
    public class CreateMedicationValidator: AbstractValidator<CreateMedicationCommand>
    {
        public CreateMedicationValidator()
        {
            RuleFor(c => c.MedicationName)
            .NotEmpty().WithMessage("MedicationName is required.")
            .MaximumLength(100);

            RuleFor(c => c.Strength)
                .NotEmpty().WithMessage("Strength is required")
                .MaximumLength(100);


            RuleFor(c => c.Indication)
                .NotEmpty().WithMessage("Indication is required")
                .MaximumLength(100);
        }
    }
}
