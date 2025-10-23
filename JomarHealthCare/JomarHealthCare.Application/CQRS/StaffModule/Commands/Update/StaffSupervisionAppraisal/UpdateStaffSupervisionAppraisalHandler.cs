using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public class UpdateStaffSupervisionAppraisalHandler : IRequestHandler<UpdateStaffSupervisionAppraisalCommand, bool>
    {
        private readonly IStaffSupervisionAppraisalRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateStaffSupervisionAppraisalHandler(IStaffSupervisionAppraisalRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateStaffSupervisionAppraisalCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffSupervisionAppraisal>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
