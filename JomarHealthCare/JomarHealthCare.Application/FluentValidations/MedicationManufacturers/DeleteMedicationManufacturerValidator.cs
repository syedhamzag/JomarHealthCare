using FluentValidation;
using JomarHealthCare.Application.CQRS.MedicationManufacturers.Command;

namespace JomarHealthCare.Application.FluentValidations.MedicationManufacturers
{
    public class DeleteMedicationManufacturerValidator:AbstractValidator<DeleteMedicationManufacturerCommand>
    {
        public DeleteMedicationManufacturerValidator()
        {
            RuleFor(c => c.MedicationManufacturerId)
         .NotEmpty().WithMessage("MedicationManufacturer is required.");
        }
    }
}
