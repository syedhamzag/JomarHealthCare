using MediatR;
using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands.User
{
    public class UpdateApplicationUserCommandHandler : IRequestHandler<UpdateApplicationUserCommand, string>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UpdateApplicationUserCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<string> Handle(UpdateApplicationUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.Id);
            if (user == null) throw new Exception(nameof(ApplicationUser) + " not found");

            user.PhoneNumber = request.PhoneNumber;
            user.CompanyId = request.CompanyId;
            if(!string.IsNullOrEmpty(request.Email))
                user.Email = request.Email;
            if (!string.IsNullOrEmpty(request.UserName))
                user.UserName = request.UserName;
            if (!string.IsNullOrEmpty(request.Password))
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, request.Password);
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
                throw new Exception(string.Join("; ", result.Errors.Select(e => e.Description)));

            return user.Id;
        }
    }
}