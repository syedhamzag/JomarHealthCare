using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Account.Commands;


internal class AddSuperAdminCommandHandler : IRequestHandler<AddSuperAdminCommand, string>
{
    private readonly IApplicationUserRepository applicationUserRepository;
    private readonly UserManager<ApplicationUser> userManager;
    private readonly RoleManager<IdentityRole> roleManager;

    public AddSuperAdminCommandHandler(
        IApplicationUserRepository applicationUserRepository,
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager)
    {
        this.applicationUserRepository = applicationUserRepository;
        this.userManager = userManager;
        this.roleManager = roleManager;
    }

    public async Task<string> Handle(AddSuperAdminCommand request, CancellationToken cancellationToken)
    {
        // 1. Check if user already exists
        var existingUser = await userManager.FindByEmailAsync(request.DataModel.Email);
        if (existingUser != null)
        {
            throw new ValidationException(new List<ValidationFailure>
            {
                new ValidationFailure(nameof(request.DataModel.Email), "User with this email already exists.")
            });
        }

        // 2. Create new ApplicationUser instance
        var user = new ApplicationUser
        {
            UserName = request.DataModel.Email,
            Email = request.DataModel.Email,
            EmailConfirmed = true
        };

        // 3. Create the user
        var createResult = await userManager.CreateAsync(user, request.DataModel.Password);
        if (!createResult.Succeeded)
        {
            throw new ValidationException(createResult.Errors
                .Select(error => new ValidationFailure(error.Code, error.Description))
                .ToList());
        }

        // 4. Ensure the SuperAdmin role exists
        var roleExists = await roleManager.RoleExistsAsync("SuperAdmin");
        if (!roleExists)
        {
            var roleResult = await roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
            if (!roleResult.Succeeded)
            {
                throw new Exception("Failed to create SuperAdmin role.");
            }
        }

        // 5. Assign role to user
        var addRoleResult = await userManager.AddToRoleAsync(user, "SuperAdmin");
        if (!addRoleResult.Succeeded)
        {
            throw new Exception("Failed to assign SuperAdmin role to user.");
        }

        // 6. Generate access token
        var claims = await userManager.GetClaimsAsync(user);
        var token = applicationUserRepository.GenerateToken(user, claims);

        // 7. Return token or email as confirmation
        return token;
    }
}
