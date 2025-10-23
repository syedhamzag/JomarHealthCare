using FluentValidation;
using JomarHealthCare.Application.CQRS.MedicationManufacturers.Command;

namespace JomarHealthCare.Application.FluentValidations.MedicationManufacturers
{
    public class UpdateMedicationManufacturerValidator: AbstractValidator<UpdateMedicationManufacturerCommand>
    {
        public UpdateMedicationManufacturerValidator()
        {
            RuleFor(c => c.MedicationManufacturerId)
          .NotEmpty().WithMessage("MedicationManufacturer is required.");


            RuleFor(c => c.Manufacturer)
               .NotEmpty().WithMessage("Manufacturer required")
               .MaximumLength(100);
        }
    }
}
