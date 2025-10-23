using FluentValidation;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.FluentValidations.Staff
{
    public class StaffEducationValidator : AbstractValidator<StaffEducationDataModel>
    {
        public StaffEducationValidator()
        {
           
            RuleFor(x => x.Institution)
                .NotEmpty().WithMessage("Institution is required.")
                .Length(2, 100).WithMessage("Institution name must be between 2 and 100 characters.");

            RuleFor(x => x.Certificate)
                .NotEmpty().WithMessage("Certificate is required.")
                .Length(2, 100).WithMessage("Certificate name must be between 2 and 100 characters.");

            RuleFor(x => x.Location)
                .NotEmpty().WithMessage("Location is required.")
                .Length(2, 100).WithMessage("Location must be between 2 and 100 characters.");

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address is required.")
                .Length(5, 200).WithMessage("Address must be between 5 and 200 characters.");

            RuleFor(x => x.StartDate)
                .NotEmpty().WithMessage("Start date is required.")
                .Must(BeValidDate).WithMessage("Start date must be a valid date.");

            RuleFor(x => x.EndDate)
                .NotEmpty().WithMessage("End date is required.")
                .Must(BeValidDate).WithMessage("End date must be a valid date.")
                .Must((model, endDate) => IsAfter(model.StartDate, endDate))
                    .WithMessage("End date must be after start date.");

            RuleFor(x => x.CertificateAttachment)
                .NotEmpty().WithMessage("Certificate attachment is required.");
        }

        private bool BeValidDate(string date)
        {
            return DateTime.TryParse(date, out _);
        }

        private bool IsAfter(string start, string end)
        {
            if (DateTime.TryParse(start, out var startDate) && DateTime.TryParse(end, out var endDate))
            {
                return endDate > startDate;
            }
            return false;
        }
    }
}