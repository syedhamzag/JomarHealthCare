using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using JomarHealthCare.Application;
using JomarHealthCare.Application.Configs;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JomarHealthCare.Repository.Repositories
{
    public class ApplicationUserRepository : GenericRepository<ApplicationUser>, IApplicationUserRepository
    {

        private readonly UserManager<ApplicationUser> userManager;
        private readonly ICompanyRepository companyRepository;
        private readonly ICategoryOfStaffRepository categoryOfStaffRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IStaffPersonalInfoRepository staffPersonalInfoRepository;
        private readonly JwtOptions jwtOptions;

        public ApplicationUserRepository(IUnitOfWork dbContext,
            UserManager<ApplicationUser> userManager,
            IOptionsSnapshot<JwtOptions> jwtOptions,
            ICompanyRepository companyRepository,
            IStaffPersonalInfoRepository staffPersonalInfoRepository,
            IUnitOfWork unitOfWork,
            ICategoryOfStaffRepository categoryOfStaffRepository) : base(dbContext)
        {
            this.userManager = userManager;
            this.companyRepository = companyRepository;
            this.jwtOptions = jwtOptions.Value;
            this.staffPersonalInfoRepository = staffPersonalInfoRepository;
            this.unitOfWork = unitOfWork;
            this.categoryOfStaffRepository = categoryOfStaffRepository;
        }

        public string GenerateToken(ApplicationUser user, IEnumerable<Claim> claims)
        {

            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SecretKey!)),
                SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(jwtOptions.IssuerName,
                jwtOptions.Audience,
                claims,
                null,
                DateTime.UtcNow.AddHours(24),
                signingCredentials);

            var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenValue;
        }

        public async Task<IdentityResult> OnboardCompanyAsync(Application.DataModels.Company.OnboardDataModel dto)
        {
            var company = new Company
            {
                CompanyName = dto.CompanyName,
                Telephone = dto.PhoneNumber,
                CompanyCode = await companyRepository.GenerateUniqueCompanyCodeAsync()
            };

            var ApplicationUser = new ApplicationUser
            {
                Email = dto.EmailAddress,
                UserName = dto.EmailAddress,
                PhoneNumber = dto.PhoneNumber,
                Company = company
            };


            // await companyRepository.AddAsync(company);

            var result = await userManager.CreateAsync(ApplicationUser, dto.Password);

            if (result.Succeeded)
            {
                //add claims
                await AddUserClaimsAsync(ApplicationUser, company.CompanyId.ToString());

                await AddUserToRoleAsync(ApplicationUser, Domain.Enums.AppRole.Company.ToString());
            }

            return result;
        }

        public async Task<(IdentityResult, string)> GenerateEmailConfirmationTokenAsync(string userName, CancellationToken cancellationToken)
        {

            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
            {
                var result = IdentityResult.Failed([new IdentityError() { Code = "NotFound", Description = "User not found" }]);
                return (result, "");
            }
            var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

            return (IdentityResult.Success, code);
        }

        public async Task<IdentityResult> ConfirmEmailTokenAsync(string userName, string code, CancellationToken cancellationToken)
        {
            var token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
            {
                var result = IdentityResult.Failed([new IdentityError() { Code = "NotFound", Description = "User not found" }]);
                return result;
            }

            var identityResult = await userManager.ConfirmEmailAsync(user, token);
            return identityResult;
        }

        public async Task<(IdentityResult, string, ApplicationUser?)> GeneratePasswordResetTokenAsync(string userName, CancellationToken cancellationToken)
        {

            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
            {
                var result = IdentityResult.Failed([new IdentityError() { Code = "NotFound", Description = "User not found" }]);
                return (result, "", null);
            }
            var code = await userManager.GeneratePasswordResetTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

            return (IdentityResult.Success, code, user);
        }

        public async Task<IdentityResult> ResetPasswordAsync(string userName, string code, string newPassword, CancellationToken cancellationToken)
        {
            var token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
            {
                var result = IdentityResult.Failed([new IdentityError() { Code = "NotFound", Description = "User not found" }]);
                return result;
            }

            var identityResult = await userManager.ResetPasswordAsync(user, token, newPassword);
            return identityResult;
        }

        public async Task<IdentityResult> ChangePasswordAsync(string userName, string currentPassword, string newPassword, CancellationToken cancellationToken)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
            {
                var result = IdentityResult.Failed([new IdentityError() { Code = "NotFound", Description = "User not found" }]);
                return result;
            }

            var changePasswordResult = await userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            return changePasswordResult;
        }

        public async Task<(IdentityResult, string)> GenerateOtpAsync(string userName, string purpose)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
            {
                var result = IdentityResult.Failed([new IdentityError() { Code = "NotFound", Description = "User not found" }]);
                return (result, "");
            }

            var otp = await userManager.GenerateUserTokenAsync(user, "TotpTokenProvider", purpose);

            return (IdentityResult.Success, otp);
        }

        public async Task<IdentityResult> ValidateOtpAsync(string userName, string purpose, string otp)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
            {
                var result = IdentityResult.Failed([new IdentityError() { Code = "NotFound", Description = "User not found" }]);
                return result;
            }

            var verificationResult = await userManager.VerifyUserTokenAsync(user, "TotpTokenProvider", purpose, otp);

            if (!verificationResult)
            {
                var result = IdentityResult.Failed([new IdentityError() { Code = "Invalid", Description = "Invalid or expired otp" }]);
                return result;
            }

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> ConfirmEmailAsync(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user is null)
            {
                var result = IdentityResult.Failed([new IdentityError() { Code = "NotFound", Description = "User not found" }]);
                return result;
            }
            user!.EmailConfirmed = true;
            var confirmationResult = await userManager.UpdateAsync(user!);
            return confirmationResult;
        }

        public async Task<IdentityResult> AddUserClaimsAsync(ApplicationUser user, List<Claim> claims)
        {
            var result = await userManager.AddClaimsAsync(user, claims);
            return result;
        }

        async Task AddUserClaimsAsync(ApplicationUser user, string companyId)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id),
                new Claim(ClaimTypes.Email,user.Email!),
                new Claim(ClaimTypes.MobilePhone,user.PhoneNumber!),
                new Claim("companyid",companyId)
            };

            _ = await userManager.AddClaimsAsync(user, claims);
        }

        async Task AddUserToRoleAsync(ApplicationUser user, string role)
        {
            _ = await userManager.AddToRoleAsync(user, role);
        }

        async Task AddUserToRolesAsync(ApplicationUser user, List<string> roles)
        {
            _ = await userManager.AddToRolesAsync(user, roles);
        }

        public async Task<IdentityResult> OnboardStaffAccountAsync(OnboardStaffAccountDataModel dto)
        {
            var staffInfo = new StaffPersonalInfo
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                CompanyId = dto.CompanyId
            };

            var ApplicationUser = new ApplicationUser
            {
                Email = dto.Email,
                UserName = dto.Email,
                PhoneNumber = dto.PhoneNo,
                CompanyId = dto.CompanyId,
                StaffPersonalInfo = staffInfo
            };
            await staffPersonalInfoRepository.AddAsync(staffInfo);
            var result = await userManager.CreateAsync(ApplicationUser, dto.Password);
            if (result.Succeeded)
            {
                await AddUserToRoleAsync(ApplicationUser, Domain.Enums.AppRole.Staff.ToString());
            }
            await unitOfWork.SaveChangesAsync();
            return result;
        }

        public async Task<IdentityResult> OnboardStaffAccountByCompanyAsync(OnboardByCompanyStaffAccountDataModel dto)
        {
            // Check if a user with the same email already exists
            var existingUser = await userManager.Users
                .Include(u => u.StaffPersonalInfo)
                .FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (existingUser != null)
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Code = "StaffAlreadyExists",
                    Description = $"Staff account already exists with email: {dto.Email}"
                });
            }

            // Create staff personal info
            var staffId = Guid.NewGuid();
            var staffInfo = new StaffPersonalInfo
            {
                FirstName = dto.FirstName,
                MiddleName = dto.MiddleName,
                LastName = dto.LastName,
                Gender = dto.Gender,
                Email = dto.Email,
                PostCode = dto.PostCode,
                Telephone = dto.Telephone,
                PlaceOfBirth = dto.PlaceOfBirth,
                CategoryId = dto.CategoryId,
                JobPositionId = dto.JobPositionId,
                StartDate = DateTime.UtcNow,
                DateOfBirth = dto.DateOfBirth,
                CompanyId = dto.CompanyId,
                Status = Domain.Enums.StaffRegistrationEnum.Approved,
                RegistrationId = $"{dto.CompanyInitialName}/ST/{DateTime.UtcNow:yy}/{staffId.ToString().Substring(0, 6).ToUpper()}"
            };

            // Create new ApplicationUser
            var applicationUser = new ApplicationUser
            {
                Email = dto.Email,
                UserName = dto.Email,
                PhoneNumber = dto.Telephone,
                CompanyId = dto.CompanyId,
                StaffPersonalInfo = staffInfo
            };

            // Create the user in the identity system (you might want to provide a default or temporary password here)
            var result = await userManager.CreateAsync(applicationUser, dto.Password); // make sure dto.Password is passed and validated

            if (result.Succeeded)
            {
                await AddUserToRoleAsync(applicationUser, Domain.Enums.AppRole.Staff.ToString());
                await unitOfWork.SaveChangesAsync();
            }
            else
            {
                var errorMessages = result.Errors?.Select(e => $"{e.Code}: {e.Description}") ?? Enumerable.Empty<string>();
                var errorText = string.Join(" | ", errorMessages);
                throw new ValidationException($"Failed to create user '{dto.Email}'. Errors: {errorText}");
            }

            return result;
        }

    }
}
