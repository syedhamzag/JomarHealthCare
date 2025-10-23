using FluentValidation;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffEmergencyContactValidator : AbstractValidator<StaffEmergencyContactDataModel>
    {
        public CreateStaffEmergencyContactValidator()
        {
            RuleFor(x => x.ContactName).NotEmpty();
            RuleFor(x => x.Telephone).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Relationship).NotEmpty();
            RuleFor(x => x.StaffPersonalInfoId).NotEmpty();
        }
    }
}