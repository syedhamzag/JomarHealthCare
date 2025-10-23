using FluentValidation;
using JomarHealthCare.Application.CQRS.Medications.Commands;

namespace JomarHealthCare.Application.FluentValidations.Medication
{
    public class DeleteMedicationValidation: AbstractValidator<DeleteMedicationCommand>
    {
        public DeleteMedicationValidation()
        {
            RuleFor(c => c.MedicationId)
          .NotEmpty().WithMessage("MedicationId is required.");
        }
    }
}
