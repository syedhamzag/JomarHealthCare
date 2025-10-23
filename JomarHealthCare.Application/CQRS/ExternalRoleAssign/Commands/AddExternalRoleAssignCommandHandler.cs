using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.ExternalUser;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Commands;


internal class AddExternalRoleAssignCommandHandler : IRequestHandler<AddExternalRoleAccessCommand, ExternalRoleAccessDataModel>
{
    private readonly IEmailService _emailService;
    private readonly IExternalRoleAccessRepository _externalRoleAssign;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _uow;

    public AddExternalRoleAssignCommandHandler(IEmailService emailService,
        IApplicationUserRepository applicationUserRepository,
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IExternalRoleAccessRepository externalRoleAssign, IMapper mapper, IUnitOfWork uow)
    {
        _externalRoleAssign = externalRoleAssign;
        _mapper = mapper;
        _uow = uow;
        _emailService = emailService;
    }

    public async Task<ExternalRoleAccessDataModel> Handle(AddExternalRoleAccessCommand request, CancellationToken cancellationToken)
    {
        
        var entity = _mapper.Map<ExternalRoleAccess>(request.DataModel);
        var created = await _externalRoleAssign.AddAsync(entity);
        await _uow.SaveChangesAsync(cancellationToken);

        return _mapper.Map<ExternalRoleAccessDataModel>(created);
    }
}
