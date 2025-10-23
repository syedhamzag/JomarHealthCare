using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Commands.Create;

public record OnboardStaffByCompanyCommand(OnboardByCompanyStaffAccountDataModel DataModel) : IRequest<bool>;
internal class OnBoardStaffByCompanyCommandHandler : IRequestHandler<OnboardStaffByCompanyCommand,bool>
{
    private readonly IApplicationUserRepository applicationUserRepository;
    private readonly IEmailService emailService;

    public OnBoardStaffByCompanyCommandHandler(IApplicationUserRepository applicationUserRepository,
        IEmailService emailService)
    {
        this.applicationUserRepository = applicationUserRepository;
        this.emailService = emailService;
    }
    public async Task<bool> Handle(OnboardStaffByCompanyCommand request, CancellationToken cancellationToken)
    {
        var onboardingResult = await applicationUserRepository.OnboardStaffAccountByCompanyAsync(request.DataModel);

        if (!onboardingResult.Succeeded)
        {
            var errorDescriptions = onboardingResult.Errors
                .Select(e => e.Description)
                .ToList();

            var errorMessage = string.Join("; ", errorDescriptions);
            return false;
            throw new KeyNotFoundException($"Onboarding failed: {errorMessage}");
        }

        var otp = await applicationUserRepository.GenerateOtpAsync(request.DataModel.Email, "verify_email");
        await emailService.SendEmailAsync(
            request.DataModel.Email,
            "Welcome onboard",
            $"Welcome to JomarHealthCare, your login credentials are:\n\nUsername: {request.DataModel.Email}\nPassword: {request.DataModel.Password}"
        );
        return true;
    }
}