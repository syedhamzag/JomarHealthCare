using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Account.Commands;


internal class UpdateSuperAdminCommandHandler : IRequestHandler<UpdateSuperAdminCommand, string>
{
    private readonly IApplicationUserRepository applicationUserRepository;
    private readonly UserManager<ApplicationUser> userManager;
    private readonly RoleManager<IdentityRole> roleManager;

    public UpdateSuperAdminCommandHandler(
        IApplicationUserRepository applicationUserRepository,
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager)
    {
        this.applicationUserRepository = applicationUserRepository;
        this.userManager = userManager;
        this.roleManager = roleManager;
    }

    public async Task<string> Handle(UpdateSuperAdminCommand request, CancellationToken cancellationToken)
    {
        // 1. Check if user already exists
        var existingUser = await userManager.FindByEmailAsync(request.DataModel.Email);
        if (existingUser == null)
        {
            throw new ValidationException(new List<ValidationFailure>
            {
                new ValidationFailure(nameof(request.DataModel.Email), "User not exists.")
            });
        }
        // 2. Ensure the SuperAdmin role exists
        var roleExists = await roleManager.RoleExistsAsync("SuperAdmin");
        if (!roleExists)
        {
            var roleResult = await roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
            if (!roleResult.Succeeded)
            {
                throw new Exception("Failed to create SuperAdmin role.");
            }
        }
        // 3. Check if user role is SuperAdmin then removed otherwise add it
        var isSuperAdmin = await userManager.IsInRoleAsync(existingUser, "SuperAdmin");
        if (isSuperAdmin)
        {
            var removeRoleResult = await userManager.RemoveFromRoleAsync(existingUser, "SuperAdmin");
            if (!removeRoleResult.Succeeded)
            {
                throw new Exception("Failed to remove SuperAdmin role from user.");
            }
            return "SuperAdmin role removed successfully.";
        }
        else
        {
            var addRoleResult = await userManager.AddToRoleAsync(existingUser, "SuperAdmin");
            if (!addRoleResult.Succeeded)
            {
                throw new Exception("Failed to assign SuperAdmin role to user.");
            }
            return "SuperAdmin role assigned successfully.";
        }
    }
}
