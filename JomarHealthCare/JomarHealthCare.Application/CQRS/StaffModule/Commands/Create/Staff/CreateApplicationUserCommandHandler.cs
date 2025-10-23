using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands.User
{
    public class CreateApplicationUserCommandHandler : IRequestHandler<CreateApplicationUserCommand,ApplicationUser>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICompanyRepository _companyRepository;

        public CreateApplicationUserCommandHandler(UserManager<ApplicationUser> userManager, ICompanyRepository companyRepository)
        {
            _userManager = userManager;
            _companyRepository = companyRepository;
        }

        public async Task<ApplicationUser> Handle(CreateApplicationUserCommand request, CancellationToken cancellationToken)
        {
            var compId = await _companyRepository.Get().FirstOrDefaultAsync();
            var company = await _companyRepository.GetByKeyAsync(request.CompanyId, cancellationToken);
            if (company == null)
            {
                throw new KeyNotFoundException("INVALID COMPANY ID : COMPANY NOT FOUND");
            }
            var user = new ApplicationUser
            {
                UserName = request.UserName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                CompanyId = request.CompanyId
            };

            var result = await _userManager.CreateAsync(user);
            if (!result.Succeeded)
                throw new Exception(string.Join("; ", result.Errors.Select(e => e.Description)));

            return user;
        }
    }


}