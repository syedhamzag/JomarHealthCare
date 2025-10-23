using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Commands
{
    public class UpdateExternalRoleAccessHandler : IRequestHandler<UpdateExternalRoleAccessCommand, bool>
    {
        private readonly IExternalRoleAccessRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;

        public UpdateExternalRoleAccessHandler(IEmailService emailService, IExternalRoleAccessRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _emailService = emailService;
        }

        public async Task<bool> Handle(UpdateExternalRoleAccessCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ExternalRoleAccess>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}