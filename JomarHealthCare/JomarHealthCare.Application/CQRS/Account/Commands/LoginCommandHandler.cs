using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Account;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.ViewModels.Account;
using JomarHealthCare.Domain.Entities;
using System.Security.Claims;

namespace JomarHealthCare.Application.CQRS.Account.Commands
{
    public record LoginCommand(LoginDataModel DataModel) : IRequest<LoginViewModel>;
    internal class LoginCommandHandler : IRequestHandler<LoginCommand, LoginViewModel>
    {
        private readonly IApplicationUserRepository applicationUserRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public LoginCommandHandler(IApplicationUserRepository applicationUserRepository,
            UserManager<ApplicationUser> userManager)
        {
            this.applicationUserRepository = applicationUserRepository;
            this.userManager = userManager;
        }
        public async Task<LoginViewModel> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await userManager.Users
                        .Include(u => u.Company) // Include company details
                        .FirstOrDefaultAsync(u => u.Email == request.DataModel.EmailAddress);

            if (user == null)
            {
                return new LoginViewModel
                {
                    Message = "Invalid email or password.",
                };
            }

            var isValid = await userManager.CheckPasswordAsync(user, request.DataModel.Password);
            if (!isValid)
            {
                return new LoginViewModel
                {
                    Message = "Password is incorrect.",
                };
            }

            var userClaims = await userManager.GetClaimsAsync(user);
            var userRoles = await userManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim("UserId", user.Id),
                new Claim("Username", user.UserName ?? ""),
                new Claim("Email", user.Email ?? ""),
                new Claim("CompanyId", user.CompanyId?.ToString() ?? ""),
                new Claim("CompanyName", user.Company?.CompanyName ?? "")
            };

            // ✅ Add only the first role
            var firstRole = userRoles.Any(s=>s.Equals("SuperAdmin")) ? userRoles.Where(s => s.Equals("SuperAdmin")).FirstOrDefault() : userRoles.FirstOrDefault();
            if (!string.IsNullOrEmpty(firstRole))
            {
                claims.Add(new Claim("Role", firstRole));
            }

            // Include any other custom user claims
            claims.AddRange(userClaims);


            var accessToken = applicationUserRepository.GenerateToken(user, claims);

            return new LoginViewModel
            {
                Message = "Login Successful",
                Token = accessToken
            };
        }
    }

}
