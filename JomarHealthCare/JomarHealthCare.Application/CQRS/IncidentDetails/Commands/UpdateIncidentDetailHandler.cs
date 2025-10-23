using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.IncidentDetails.Commands
{
    public class UpdateIncidentDetailHandler : IRequestHandler<UpdateIncidentDetailCommand, bool>
    {
        private readonly IIncidentDetailRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;

        public UpdateIncidentDetailHandler(IEmailService emailService, IIncidentDetailRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _emailService = emailService;
        }

        public async Task<bool> Handle(UpdateIncidentDetailCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<IncidentDetail>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}