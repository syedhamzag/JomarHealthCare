using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffInfectionControlHandler : IRequestHandler<UpdateStaffInfectionControlCommand, bool>
    {
        private readonly IStaffInfectionControlRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateStaffInfectionControlHandler(IStaffInfectionControlRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateStaffInfectionControlCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffInfectionControl>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}