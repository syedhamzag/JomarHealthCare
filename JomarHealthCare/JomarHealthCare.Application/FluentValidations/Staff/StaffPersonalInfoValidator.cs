using FluentValidation;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.FluentValidations.Staff
{
    public class StaffPersonalInfoValidator : AbstractValidator<OnboardStaffDataModel>
    {
        public StaffPersonalInfoValidator(
            IApplicationUserRepository userRepository,
            IStaffPersonalInfoRepository staffRepository)
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .Length(2, 50).WithMessage("First name must be between 2 and 50 characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .Length(2, 50).WithMessage("Last name must be between 2 and 50 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.")
                .MustAsync(async (email, cancellation) =>
                {
                    var exists = await staffRepository.ExistsAsync(x => x.Email == email);
                    return !exists;
                }).WithMessage("Email already exists.");

            RuleFor(x => x.DateOfBirth)
                .NotEmpty().WithMessage("Date of birth is required.")
                .Must(dob => dob <= DateTime.Today).WithMessage("Date of birth cannot be in the future.")
                .Must(dob => dob <= DateTime.Today.AddYears(-15)).WithMessage("Person must be at least 15 years old.");
        }
    }
}