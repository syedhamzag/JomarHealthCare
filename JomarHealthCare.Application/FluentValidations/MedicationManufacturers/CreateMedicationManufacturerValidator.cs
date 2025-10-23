using FluentValidation;
using JomarHealthCare.Application.CQRS.MedicationManufacturers.Command;

namespace JomarHealthCare.Application.FluentValidations.MedicationManufacturers
{
    public class CreateMedicationManufacturerValidator: AbstractValidator<CreateMedicationManufacturerCommand>
    {
        public CreateMedicationManufacturerValidator()
        {
            RuleFor(c => c.Manufacturer)
            .NotEmpty().WithMessage("Manufacturer is required.")
            .MaximumLength(100);

          
        }
    }
}
