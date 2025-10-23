using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.StaffModule.Commands.Create;


public record OnboardStaffCommand(OnboardStaffAccountDataModel DataModel) : IRequest<string>;
internal class OnBoardStaffCommandHandler : IRequestHandler<OnboardStaffCommand, string>
{
    private readonly IApplicationUserRepository applicationUserRepository;
    private readonly IEmailService emailService;
    private readonly ICompanyRepository _companyRepository;

    public OnBoardStaffCommandHandler(IApplicationUserRepository applicationUserRepository, ICompanyRepository companyRepository,
        IEmailService emailService)
    {
        this.applicationUserRepository = applicationUserRepository;
        this.emailService = emailService;
        _companyRepository = companyRepository;
    }
    public async Task<string> Handle(OnboardStaffCommand request, CancellationToken cancellationToken)
    {
        var compExist = await _companyRepository.GetCompanyByCode(request.DataModel.CompanyCode);
        if(compExist == null)
        {
            return "Company Code is wrong";
        }

        request.DataModel.CompanyId = compExist.CompanyId;
        var onboardingResult = await applicationUserRepository.OnboardStaffAccountAsync(request.DataModel);

        if (!onboardingResult.Succeeded)
        {
            var errorDescriptions = onboardingResult.Errors
                .Select(e => e.Description)
                .ToList();

            var errorMessage = string.Join("; ", errorDescriptions);
            return errorMessage;
        }

        var otp = await applicationUserRepository.GenerateOtpAsync(request.DataModel.Email, "verify_email");
        await emailService.SendEmailAsync(request.DataModel.Email, "Welcome", $"Welcome to JomarHealthCare!");
        return "Staff Register Successfully";
    }
}
