using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public class CreateStaffSupervisionAppraisalHandler : IRequestHandler<CreateStaffSupervisionAppraisalCommand, StaffSupervisionAppraisalDataModel>
    {
        private readonly IStaffSupervisionAppraisalRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffSupervisionAppraisalHandler(IStaffSupervisionAppraisalRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<StaffSupervisionAppraisalDataModel> Handle(CreateStaffSupervisionAppraisalCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffSupervisionAppraisal>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffSupervisionAppraisalDataModel>(created);
        }
    }
}
