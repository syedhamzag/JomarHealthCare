using FluentValidation;
using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Application.CQRS.Company.Commands;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.FluentValidations.Company
{
    public class OnboardValidator : AbstractValidator<OnboardCommand>
    {
        public OnboardValidator(IPasswordValidator<ApplicationUser> passwordValidator,
            IUserValidator<ApplicationUser> userValidator,
            UserManager<ApplicationUser> userManager)
        {
            RuleFor(c => c.DataModel.CompanyName)
                .MaximumLength(255)
                .NotEmpty();

            RuleFor(c => c.DataModel.EmailAddress)
                .EmailAddress();

            RuleFor(c => c.DataModel.PhoneNumber)
                .NotEmpty();

            RuleFor(c => c.DataModel.Password)
                .NotEmpty();

            RuleFor(c => c.DataModel.ConfirmPassword)
                .NotEmpty()
                .Equal(c => c.DataModel.Password)
                .WithMessage("Password and Confirm Password do not match.");

            RuleFor(c => c)
                .CustomAsync(async (model, context, token) =>
                {
                    var user = new ApplicationUser
                    {
                        UserName = model.DataModel.EmailAddress,
                        Email = model.DataModel.EmailAddress,
                        PhoneNumber = model.DataModel.PhoneNumber
                    };

                    var passwordResult = await passwordValidator.ValidateAsync(userManager, user, model.DataModel.Password);

                    if (!passwordResult.Succeeded)
                    {
                        foreach (var error in passwordResult.Errors)
                        {
                            context.AddFailure(nameof(model.DataModel.Password), error.Description);
                        }
                    }

                    var userResult = await userValidator.ValidateAsync(userManager, user);
                    if (!userResult.Succeeded)
                    {
                        foreach (var error in userResult.Errors)
                        {
                            context.AddFailure(nameof(model.DataModel.EmailAddress), error.Description);
                        }
                    }

                });
        }
    }
}
