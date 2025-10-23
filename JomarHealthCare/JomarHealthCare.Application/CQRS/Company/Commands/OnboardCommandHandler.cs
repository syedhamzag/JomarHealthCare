using FluentValidation.Results;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.Company;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Company.Commands
{
    public record OnboardCommand(OnboardDataModel DataModel) : IRequest;
    internal class OnboardCommandHandler : IRequestHandler<OnboardCommand>
    {
        private readonly IApplicationUserRepository applicationUserRepository;
        private readonly IEmailService emailService;

        public OnboardCommandHandler(IApplicationUserRepository applicationUserRepository,
            IEmailService emailService)
        {
            this.applicationUserRepository = applicationUserRepository;
            this.emailService = emailService;
        }
        public async Task Handle(OnboardCommand request, CancellationToken cancellationToken)
        {
            var onboardingResult = await applicationUserRepository.OnboardCompanyAsync(request.DataModel);

            if (!onboardingResult.Succeeded)
            {
                var errors = new List<ValidationFailure>();
                foreach (var error in onboardingResult.Errors)
                {
                    errors.Add(new ValidationFailure(nameof(request.DataModel.EmailAddress), error.Description));
                }

                throw new FluentValidation.ValidationException(errors);
            }

            var otp = await applicationUserRepository.GenerateOtpAsync(request.DataModel.EmailAddress, "verify_email");
            await emailService.SendEmailAsync(request.DataModel.EmailAddress, "Verify your email", $"Your email verification OTP is {otp.Item2}. It expires in 5 min");
           
        }
    }
}
