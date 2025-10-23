using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.ExternalUser.Commands
{
    public class UpdateExternalUserHandler : IRequestHandler<UpdateExternalUserCommand, bool>
    {
        private readonly IExternalRoleRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;

        public UpdateExternalUserHandler(IEmailService emailService, IExternalRoleRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _emailService = emailService;
        }

        public async Task<bool> Handle(UpdateExternalUserCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ExternalRole>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            string content = $"Dear {string.Concat(request.DataModel.FirstName, " ", request.DataModel.LastName)},\r\n\r\nYour record has been updated. If you have any questions or need further clarification, please don’t hesitate to reach out.\r\n\r\nBest regards,\r\nCare360 Team";
            await _emailService.SendEmailAsync(request.DataModel.Email, "Record Updated at Care360", content);
            return true;
        }
    }
}