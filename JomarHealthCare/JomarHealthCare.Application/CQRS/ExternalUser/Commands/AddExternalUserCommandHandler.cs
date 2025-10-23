using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Commands;


internal class AddExternalUserCommandHandler : IRequestHandler<AddExternalUserCommand, string>
{
    private readonly IApplicationUserRepository _applicationUserRepository;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IEmailService _emailService;
    private readonly IExternalRoleRepository _externalRole;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddExternalUserCommandHandler(IEmailService emailService,
        IApplicationUserRepository applicationUserRepository,
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IExternalRoleRepository externalRole, IMapper mapper, IUnitOfWork uow)
    {
        _applicationUserRepository = applicationUserRepository;
        _userManager = userManager;
        _roleManager = roleManager;
        _externalRole = externalRole;
        _mapper = mapper;
        _uow = uow;
        _emailService = emailService;
    }

    public async Task<string> Handle(AddExternalUserCommand request, CancellationToken cancellationToken)
    {
        // 1. Check if user already exists
        var existingUser = await _userManager.FindByEmailAsync(request.DataModel.Email);
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
        var createResult = await _userManager.CreateAsync(user, request.DataModel.Password);
        if (!createResult.Succeeded)
        {
            throw new ValidationException(createResult.Errors
                .Select(error => new ValidationFailure(error.Code, error.Description))
                .ToList());
        }

        // 4. Ensure the ExternalUser role exists
        var roleExists = await _roleManager.RoleExistsAsync("ExternalUser");
        if (!roleExists)
        {
            var roleResult = await _roleManager.CreateAsync(new IdentityRole("ExternalUser"));
            if (!roleResult.Succeeded)
            {
                throw new Exception("Failed to create ExternalUser role.");
            }
        }

        // 5. Assign role to user
        var addRoleResult = await _userManager.AddToRoleAsync(user, "ExternalUser");
        if (!addRoleResult.Succeeded)
        {
            throw new Exception("Failed to assign ExternalUser role to user.");
        }

        // 6. Generate access token
        var claims = await _userManager.GetClaimsAsync(user);
        var token = _applicationUserRepository.GenerateToken(user, claims);
        request.DataModel.UserId = user.Id;
        //7. (Optional) Send confirmation email or other notification
        var entity = _mapper.Map<ExternalRole>(request.DataModel);
        var created = await _externalRole.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);
        string content = $"Dear {string.Concat(request.DataModel.FirstName, " ", request.DataModel.LastName)},\r\n\r\nYou have been selected as an external User. If you have any questions or need further clarification, please don’t hesitate to reach out.\r\n\r\nBest regards,\r\nCare360 Team";
        await _emailService.SendEmailAsync(request.DataModel.Email, "Welcome to Care360", content);
        
        // 8. Return token or email as confirmation
        return token;
    }
}
