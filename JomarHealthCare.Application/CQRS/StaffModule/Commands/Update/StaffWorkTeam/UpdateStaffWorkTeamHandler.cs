using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffWorkTeamHandler : IRequestHandler<UpdateStaffWorkTeamCommand, bool>
    {
        private readonly IStaffWorkTeamRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateStaffWorkTeamHandler(IStaffWorkTeamRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateStaffWorkTeamCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffWorkTeam>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}