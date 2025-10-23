using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Domain.Entities;
using System.Security.Claims;

namespace JomarHealthCare.Application.Repositories
{
    public interface IApplicationUserRepository:IGenericRepository<ApplicationUser>
    {
        string GenerateToken(ApplicationUser user, IEnumerable<Claim> claims);
        Task<IdentityResult> OnboardCompanyAsync(Application.DataModels.Company.OnboardDataModel dto);
        Task<(IdentityResult, string)> GenerateEmailConfirmationTokenAsync(string userName, CancellationToken cancellationToken);

        Task<(IdentityResult, string)> GenerateOtpAsync(string userName, string purpose);
        Task<IdentityResult> ValidateOtpAsync(string userName, string purpose, string otp);
        Task<IdentityResult> ConfirmEmailAsync(string userName);
        Task<IdentityResult> AddUserClaimsAsync(ApplicationUser user, List<Claim> claims);

        Task<IdentityResult> OnboardStaffAccountAsync(OnboardStaffAccountDataModel dto);

        Task<IdentityResult> OnboardStaffAccountByCompanyAsync(OnboardByCompanyStaffAccountDataModel dto);
    }
}
