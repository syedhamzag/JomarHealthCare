using MediatR;
using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands.User
{
    public class DeleteApplicationUserCommandHandler : IRequestHandler<DeleteApplicationUserCommand,Unit>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public DeleteApplicationUserCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Unit> Handle(DeleteApplicationUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.Id);
            if (user == null) throw new Exception(nameof(ApplicationUser) + " NOT FOUND");

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
                throw new Exception(string.Join("; ", result.Errors.Select(e => e.Description)));

            return Unit.Value;
        }
    }


}