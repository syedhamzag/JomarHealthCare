using FluentValidation;
using JomarHealthCare.Application.CQRS.Medications.Commands;

namespace JomarHealthCare.Application.FluentValidations.Medication
{
    public class UpdateMedicationValidator : AbstractValidator<UpdateMedicationCommand>
    {
        public UpdateMedicationValidator()
        {
            RuleFor(c => c.MedicationId)
           .NotEmpty().WithMessage("MedicationId is required.");


            RuleFor(c => c.MedicationName)
               .NotEmpty().WithMessage("Lastname required")
               .MaximumLength(100);

            RuleFor(c => c.Strength)
               .NotEmpty().WithMessage("IDNO required")
               .MaximumLength(100);

            RuleFor(c => c.Indication)
                .NotEmpty().WithMessage("Email is required")
                .MaximumLength(100);

           
        }
    }
}
